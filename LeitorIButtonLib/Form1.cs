using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace LeitorIButtonLib
{
    public partial class Form1 : Form
    {

        
        private SerialPort selectedPort;
        private List<System.Windows.Forms.ListView> listas = new List<System.Windows.Forms.ListView>();
        public Form1()
        {
            InitializeComponent();
            decimal numero = InicioNum.Value;
            listas.Add(listViewDados);
            listas.Add(ListViewSuntech);
            listas.Add(ListViewE2815);

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            ListarPortasCOM();
        
        }

        private void ListarPortasCOM()
        {
            comboBoxPortasCOM.Text = null; 
            comboBoxPortasCOM.Items.Clear();
            try
            {
                string[] portasDisponiveis = SerialPort.GetPortNames();

                Console.WriteLine("Portas COM disponíveis:");

                foreach (string porta in portasDisponiveis)
                {
                    Console.WriteLine(porta);
                    comboBoxPortasCOM.Items.Add(porta);
                }

                if (portasDisponiveis.Length > 0)
                {
                    // Você pode selecionar automaticamente a primeira porta disponível
                    comboBoxPortasCOM.SelectedIndex = 0;
                }
                else
                {
                    Console.WriteLine("Nenhuma porta COM disponível.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar portas COM: " + ex.Message);
            }
        }
        
        private void IniciarComunicacao()
        {
            if (comboBoxPortasCOM.SelectedItem != null)
            {
                // Abre a porta COM selecionada
                selectedPort = new SerialPort(comboBoxPortasCOM.SelectedItem.ToString())
                {
                    BaudRate = 9600,
                };

                
                selectedPort.DataReceived += SerialPort_DataReceived;  // Adiciona o evento DataReceived
                selectedPort.Open();

                // Adicione aqui a lógica para comunicação com a porta COM (leitura de dados, etc.)
            }
        }
    
         public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Evento chamado quando dados são recebidos na porta COM
            
            if (selectedPort != null && selectedPort.IsOpen && selectedPort.BytesToRead > 0)
            {
                try
                {
                    // Lê os dados disponíveis na porta
                    string dadosRecebidos = selectedPort.ReadLine();
                    // Console.WriteLine(dadosRecebidos);

                    // Expressão regular para extrair o ID do iButton
                    string padraoRegex = @"iButton:\s0x([A-Fa-f0-9]+)";
                    Match match = Regex.Match(dadosRecebidos, padraoRegex);

                    if (match.Success)
                    {
                        string idIButton = match.Groups[1].Value;
                        Console.WriteLine(idIButton);

                        // Atualiza a lista de iButtons com o ID extraído
                         
                        TeltonikaLista(idIButton);
                        SuntechLista(idIButton);
                        E2815Lista(idIButton);
                        
                    }
                }
                catch { }
            }
        }
        
        public void TeltonikaLista(string valor)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => TeltonikaLista(valor)));
            }
            else
            {
                decimal ValueNum = InicioNum.Value;
                ListViewItem item = new ListViewItem(ValueNum.ToString("000"));
                item.SubItems.Add(valor);
                listViewDados.Items.Add(item);
                InicioNum.Value = InicioNum.Value + 1;
                CheckList();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedPort != null && selectedPort.IsOpen)
            {
                selectedPort.Close();
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            // Chama a função para iniciar a comunicação apenas se a porta COM estiver selecionada
            if (comboBoxPortasCOM.SelectedItem != null)
            {
                IniciarComunicacao();
                Abrir.Enabled = false;
            }
            else
            {
                Console.WriteLine("Selecione uma porta COM antes de abrir.");
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            if (selectedPort != null && selectedPort.IsOpen)
            {
                try
                {
                    selectedPort.Close();
                    Console.WriteLine("Porta COM fechada.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao fechar a porta COM: " + ex.Message);
                }
                finally
                {
                    Abrir.Enabled = true;
                }
            }
            else
            {
                Console.WriteLine("A porta COM não está aberta.");
            }
        }

        private void SuntechLista(string valorOriginal)
        {
            string valorModificado = ModificarSuntech(valorOriginal);

            if (InvokeRequired)
            {
                Invoke(new Action(() => SuntechLista(valorOriginal)));
            }
            else
            {
                decimal ValueNum = InicioNum.Value - 1;
                ListViewItem item = new ListViewItem(ValueNum.ToString("000"));
                item.SubItems.Add(valorModificado);
                ListViewSuntech.Items.Add(item);
            }
        }

        private void E2815Lista(string valorOriginal)
        {
            string valorModificado = Modificar2815(valorOriginal);

            if (InvokeRequired)
            {
                Invoke(new Action(() => E2815Lista(valorOriginal)));
            }
            else
            {
                decimal ValueNum = InicioNum.Value - 1;
                ListViewItem item = new ListViewItem(ValueNum.ToString("000"));
                item.SubItems.Add(valorModificado);
                ListViewE2815.Items.Add(item);
            }
        }

        private string ModificarSuntech(string input)
        {
            // Remove os dois primeiros caracteres se a string for suficientemente longa
            if (input.Length > 2)
            {
                input = input.Substring(2);
            }
            else
            {
                // Caso a string tenha 2 caracteres ou menos, ela é deixada vazia
                input = string.Empty;
            }

            // Verifica se a string possui um número par de caracteres
            if (input.Length % 2 != 0)
            {
                // Opcional: lidar com strings de comprimento ímpar
                input += "0"; // Adicionando um caractere para torná-lo par
            }

            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 2; i >= 0; i -= 2)
            {
                sb.Append(input.Substring(i, 2));
            }

            return sb.ToString();
        }

        private string Modificar2815(string input)
        {
            // Remove os dois primeiros caracteres se a string for suficientemente longa
            if (input.Length > 4)
            {
                input = input.Substring(2, input.Length - 4);
            }
            else
            {
                
                input = string.Empty;
            }

            return input.ToString();
        }

        private void TeltonikaCopy(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeletar_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;
                if (listView != null)
                {
                    StringBuilder buffer = new StringBuilder();
                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        // Verifica se o item tem um subitem na segunda coluna
                        if (item.SubItems.Count > 1)
                        {
                            buffer.AppendLine(item.SubItems[1].Text); // Adiciona apenas o texto da segunda coluna
                        }
                    }

                    if (buffer.Length > 0)
                    {
                        Clipboard.SetText(buffer.ToString());
                    }
                }
            }
        }

        private void SuntechCopy(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeletar_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;
                if (listView != null)
                {
                    StringBuilder buffer = new StringBuilder();
                    int itemCount = 0;

                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        // Verifica se o item tem um subitem na segunda coluna
                        if (item.SubItems.Count > 1)
                        {
                            itemCount++;
                            // Verifica se é o primeiro item de um grupo de cinco
                            if (itemCount % 45 == 1)
                            {
                                // Adiciona o comando "ST300HAD;[%IMEI%];02" ao buffer antes do primeiro item
                                buffer.Append("ST300HAD;[%IMEI%];02");
                            }
                            // Adiciona o texto da segunda coluna ao buffer
                            buffer.Append(";" + item.Text + ";" + item.SubItems[1].Text);

                            // Verifica se é o quinto item
                            if (itemCount % 45 == 0)
                            {
                                // Adiciona uma nova linha ao buffer
                                buffer.AppendLine();
                            }
                        }
                    }

                    if (buffer.Length > 0)
                    {
                        // Adiciona o buffer para a área de transferência
                        Clipboard.SetText(buffer.ToString());
                    }
                }
            }

        }

        private void E2815Copy(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeletar_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;
                if (listView != null)
                {
                    StringBuilder buffer = new StringBuilder();
                    int itemCount = 0;

                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        // Verifica se o item tem um subitem na segunda coluna
                        if (item.SubItems.Count > 1)
                        {
                            itemCount++;
                            // Verifica se é o primeiro item de um grupo de cinco
                            if (itemCount % 9 == 1)
                            {
                                // Adiciona o comando 0000,144 ao buffer antes do primeiro item
                                buffer.Append("144");
                            }
                            // Adiciona o ID do item ao buffer
                            buffer.Append(",#" + item.SubItems[1].Text);

                            // Verifica se é o quinto item
                            if (itemCount % 9 == 0)
                            {
                                // Adiciona uma nova linha ao buffer
                                buffer.AppendLine();
                            }
                        }
                    }

                    if (buffer.Length > 0)
                    {
                        // Adiciona o buffer para a área de transferência
                        Clipboard.SetText(buffer.ToString());
                    }

                }
            }
        }

        private void botaoChamarSuntech_Click(object sender, EventArgs e)
        {
            List<string> itensListView = new List<string>();

            // Ajuste os índices das colunas conforme necessário
            for (int i = 0; i <= 44; i++)
            {
                if (i < ListViewSuntech.Items.Count)
                {
                    ListViewItem item = ListViewSuntech.Items[i];
                    string coluna1 = "0" + item.SubItems[0].Text; // Primeira coluna
                    string coluna2 = item.SubItems[1].Text; // Segunda coluna

                    itensListView.Add(coluna1 + ";" + coluna2 );
                }
            }

            Suntech formSuntech = new Suntech();
            formSuntech.AlterarTexto("ST300HAD;[%IMEI%];02;", itensListView);
            formSuntech.Show();
        }

        private void CheckList()
        {
            Console.WriteLine(listViewDados.Items.Count);
            if (listViewDados.Items.Count <= 0)
            {
                GerarTeltonika.Enabled = false;
                GerarSuntech.Enabled = false;
                GerarE2815.Enabled = false;
            }
            else
            {
                GerarTeltonika.Enabled = true;
                GerarSuntech.Enabled = true;
                GerarE2815.Enabled = true;
            }
        }
       

        private async void EnviarMotoristas(System.Windows.Forms.ListView Lista, bool option)
        {
            using (var client = new HttpClient())
            {
                // Agora que temos o user_api_hash, vamos usar dentro do loop foreach
                List<Task> tasks = new List<Task>();
                foreach (ListViewItem item in Lista.Items)
                {
                    string nome = item.Text + " -"; // Obtém o texto do item principal

                    string rfid = item.SubItems[1].Text;
                    if (option == true)
                    {
                        rfid = rfid.Substring(4);
                    }
                    // Montando a URL da API com o nome do item e user_api_hash dinâmico
                    string url = $"http://95.216.66.168/api/add_user_driver?lang=en&user_api_hash={APIuser.Text}&name={Uri.EscapeDataString(nome)}&rfid={Uri.EscapeDataString(rfid)}";

                    // Envia a chamada da API e adiciona a tarefa à lista de tarefas
                    tasks.Add(SendApiRequest(url));
                }

                // Aguarda a conclusão de todas as tarefas
                await Task.WhenAll(tasks);
                async Task SendApiRequest(string url)
                {
                    HttpResponseMessage response2 = await client.GetAsync(url);
                    string responseBody = await response2.Content.ReadAsStringAsync();
                    if (!response2.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Erro:" + responseBody);
                    }
                }
            }
            

        }

        private void GerarTeltonika_Click(object sender, EventArgs e)
        {
            EnviarMotoristas(listViewDados, false);
        }

        private void GerarSuntech_Click(object sender, EventArgs e)
        {
            EnviarMotoristas(ListViewSuntech, false);
        }

        private void E2815_Click(object sender, EventArgs e)
        {
            EnviarMotoristas(ListViewE2815, true);
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se há algum item selecionado em qualquer ListView
            foreach (System.Windows.Forms.ListView listView in listas)
            {
                if (listView.SelectedItems.Count > 0)
                {
                    // Remove cada item selecionado de todos os ListViews
                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        // Obtém o número da linha do item selecionado
                        int rowIndex = item.Index;

                        // Você pode usar 'rowIndex' conforme necessário
                        Console.WriteLine("Número da linha selecionada: " + rowIndex);

                        listView.Items.Remove(item);
                    }
                }
            }
        }
        private void SincronizarSelecao(System.Windows.Forms.ListView listViewOrigem, int indexSelecionado)
        {
            foreach (System.Windows.Forms.ListView listView in listas)
            {
                if (listView != listViewOrigem)
                {
                    listView.SelectedIndexChanged -= listView_SelectedIndexChanged;
                    listView.Items[indexSelecionado].Selected = true;
                    listView.SelectedIndexChanged += listView_SelectedIndexChanged;
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView listViewOrigem = sender as System.Windows.Forms.ListView;
            int indexSelecionado = listViewOrigem.SelectedItems.Count > 0 ? listViewOrigem.SelectedItems[0].Index : -1;

            if (indexSelecionado != -1)
            {
                SincronizarSelecao(listViewOrigem, indexSelecionado);
            }
        }


    }

}
