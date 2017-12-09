using System.Net.Http;
using Xamarin.Forms;

namespace HelloXamarinFunctions
{
    public partial class MainPage : ContentPage
	{
        private const string Url = "https://lbxamarindemo.azurewebsites.net/api/HttpTriggerCSharp/name/{name}?code=h6kv9xW9b/m7rWu40ioBl32k2HxhMldJaUPu1jbP62FanaD5mQXNOA==";

        public MainPage()
		{
			InitializeComponent();

            GoButton.Clicked += async (s, e) =>
            {
                ResultText.Text = "Please wait";

                var client = new HttpClient();

                var result = await client.GetStringAsync(
                    Url.Replace("{name}", FirstNameText.Text));

                ResultText.Text = result;
            };
		}
	}
}
