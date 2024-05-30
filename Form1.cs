namespace gmail_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Check_Click(object sender, EventArgs e)
        {
            try
            {
                //Disable click button
                check.Enabled = false;

                var domains = domainsText.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (domains.Length == 0)
                {
                    MessageBox.Show("Please enter at least one domain");
                    return;
                }

                var tasks = domains.Select(x => new Mx(x).CheckGmailAsync()).ToList();
                var results = await Task.WhenAll(tasks);

                foreach (var result in results)
                {
                    if (result[1] == "t")
                    {
                        await File.AppendAllTextAsync("gmail.txt", result[0] + "\n");
                    }
                    else
                    {
                        await File.AppendAllTextAsync("not_gmail.txt", result[0] + "\n");
                    }
                }

                MessageBox.Show("Check completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Enable click button
                check.Enabled = true;
            }
        }
    }
}