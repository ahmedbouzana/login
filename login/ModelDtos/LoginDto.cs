using System.ComponentModel;

namespace login.ModelDtos
{
    public class LoginDto : INotifyPropertyChanged
    {
        private int _id;
        public int id
        { get { return _id; } set { if (_id != value) { _id = value; NotifyPropertyChanged(); } } }

        private string _pseudo;
        public string pseudo
        { get { return _pseudo; } set { if (_pseudo != value) { _pseudo = value; NotifyPropertyChanged(); } } }

        private string _password;
        public string password
        { get { return _password; } set { if (_password != value) { _password = value; NotifyPropertyChanged(); } } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
