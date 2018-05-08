using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;

namespace DiabetesTracker.Model
{
    public class Osoba:INotifyPropertyChanged, INotifyDataErrorInfo
    {
        String id;
        String ime;
        String prezime;
        String username;
        String password;
        String eMail;
        Spol spol;
        String JMBG;
        DateTime datumRodjenja;

        public string Id { get => id; set => id = value; }
        public virtual string Ime { get => ime; set => ime = value; }
        public virtual string Prezime { get => prezime; set => prezime = value; }
        public virtual string Username { get => username; set => username = value; }
        public virtual string Password { get => password; set => password = value; }
        public virtual string EMail { get => eMail; set => eMail = value; }
        public virtual Spol Spol { get => spol; set => spol = value; }
        public virtual string JMBG1 { get => JMBG; set => JMBG = value; }
        public virtual DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }



        //koristenje interfejsa INotifyDataErrorInfo


        public bool HasErrors
        {
            get { return (this._errors.Count > 0); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private Dictionary<string, List<String>> _errors = new Dictionary<string, List<string>>();

        public bool IsValid
        {
            get { return !this.HasErrors; }

        }

        public void AddError(string propertyName, string error)
        {
            // Add error to list
            this._errors[propertyName] = new List<string>() { error };
            this.NotifyErrorsChanged(propertyName);
        }

        public void RemoveError(string propertyName)
        {
            // remove error
            if (this._errors.ContainsKey(propertyName))
                this._errors.Remove(propertyName);
            this.NotifyErrorsChanged(propertyName);
        }

        public void NotifyErrorsChanged(string propertyName)
        {
            // Notify
            if (this.ErrorsChanged != null)
                this.ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (this._errors.ContainsKey(propertyName))
                return this._errors[propertyName];
            return null;
        }
    }
}
