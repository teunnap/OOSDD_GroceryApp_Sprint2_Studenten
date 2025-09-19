
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        [ObservableProperty]
        private string _emailAddress;
        
        [ObservableProperty]
        private string _password;
        
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            _emailAddress = emailAddress;
            _password = password;
        }
    }
}
