using AutoMapper;
using login.Commands;
using login.ModelDtos;
using login.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace login.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        List<User> users;

        public LoginViewModel()
        {
            users = new List<User>
            {
                new User{id = 1, pseudo="user1", password="1"},
                new User{id = 2, pseudo="user2", password="2"},
                new User{id = 3, pseudo="user3", password="3"}
            };
            currentUser = new LoginDto();
            LoadData();

            _searchCommand = new RelayCommand(SearchUser);
        }

        private void LoadData()
        {
            var Mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, LoginDto>();
            }).CreateMapper();

            usersList = new ObservableCollection<LoginDto>(users.Select(a => Mapper.Map<User, LoginDto>(a)));
        }

        #region SearchOperation
        private RelayCommand _searchCommand;
        public RelayCommand searchCommand
        {
            get { return _searchCommand; }
        }

        public void SearchUser()
        {
            try
            {
                if (currentUser.id != 0)
                {
                    var user = users.Where(a => a.id == currentUser.id && a.password.Equals(currentUser.password)).SingleOrDefault();
                    if (user != null)
                        currentUser = new LoginDto();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion


        #region NotifyPropertyChanged
        private LoginDto _currentUser;
        public LoginDto currentUser
        { get { return _currentUser; } set { _currentUser = value; NotifyPropertyChanged(); } }

        private ObservableCollection<LoginDto> _usersList;
        public ObservableCollection<LoginDto> usersList
        { get { return _usersList; } set { _usersList = value; NotifyPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
