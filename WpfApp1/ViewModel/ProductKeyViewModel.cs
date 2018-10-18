using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Model;
using Microsoft.Win32;



namespace WpfApp1.ViewModel
{
    public class ProductKeyViewModel : ObservableCollection<ProductKey>, INotifyPropertyChanged
    {
        #region Attributes
        private ProductKeyViewModel ProductKeys;
        private int selectedIndex;

        private int id;
        private string productName;
        private string productId;
        private string productKeyWin;
        private string installationFolder;
        private string computerName;
        private string buildNumber;
        private string modifiedTime;

        //private ICommand ViewProductKeyCommand;

        #endregion
        #region properties
        public int SelectedIndexOfCollection
        {
            get
            {
                return selectedIndex;
            }//Fin de get.
            set
            {
                selectedIndex = value;
                OnPropertyChanged("SelectedIndexOfCollection");

                //Activa el evento OnPropertyChanged de los atributos para refrescar las propiedades segun el indice seleccionado.
                OnPropertyChanged("Id");
                OnPropertyChanged("ProductName");
                OnPropertyChanged("ProductId");
                OnPropertyChanged("ProductKeyWin");
                OnPropertyChanged("InstallationFolder");
                OnPropertyChanged("ComputerName");
                OnPropertyChanged("BuildNumber");
                OnPropertyChanged("ModifiedTime");


            }//Fin de set.
        }//Fin de propiedad Name.
        #region properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string ProductKeyWin
        {
            get { return productKeyWin; }
            set { productKeyWin = value; }
        }
        public string InstallationFolder
        {
            get { return installationFolder; }
            set { installationFolder = value; }
        }
        public string ComputerName
        {
            get { return computerName; }
            set { computerName = value; }
        }
        public string BuildNumber
        {
            get { return buildNumber; }
            set { buildNumber = value; }
        }
        public string ModifiedTime
        {
            get { return modifiedTime; }
            set { modifiedTime = value; }
        }
          
        /*
        public int Id
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].Id;
                }//Fin de if.
                else
                {
                    return id;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].Id = value;
                }//Fin de if.
                else
                {
                    id = value;
                }//Fin de else.
                OnPropertyChanged("Id");
            }//Fin de set.
        }//Fin de propiedad Id.

        public string ProductName
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].ProductName;
                }//Fin de if.
                else
                {
                    return productName;
                }//Fin de else. 
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].ProductName = value;
                }//Fin de if.
                else
                {
                    productName = value;
                }//Fin de else.
                OnPropertyChanged("ProductName");
            }//Fin de set.
        }//Fin de propiedad Name.

        public string ProductId
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].ProductId;
                }//Fin de if.
                else
                {
                    return productId;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].ProductId = value;
                }//Fin de if.
                else
                {
                    productId = value;
                }//Fin de else.
                OnPropertyChanged("ProductId");
            }//Fin de set.
        }//Fin de propiedad ProductId.
        public string ProductKeyWin
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].ProductKeyWin;
                }//Fin de if.
                else
                {
                    return productKeyWin;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].ProductKeyWin = value;
                }//Fin de if.
                else
                {
                    productKeyWin = value;
                }//Fin de else.
                OnPropertyChanged("ProductKeyWin");
            }//Fin de set.
        }//Fin de propiedad ProductKeyWin.
        public string InstallationFolder
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].InstallationFolder;
                }//Fin de if.
                else
                {
                    return installationFolder;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].InstallationFolder = value;
                }//Fin de if.
                else
                {
                    installationFolder = value;
                }//Fin de else.
                OnPropertyChanged("InstallationFolder");
            }//Fin de set.
        }//Fin de propiedad InstallationFolder.
        public string ComputerName
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].ComputerName;
                }//Fin de if.
                else
                {
                    return computerName;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].ComputerName = value;
                }//Fin de if.
                else
                {
                    computerName = value;
                }//Fin de else.
                OnPropertyChanged("ComputerName");
            }//Fin de set.
        }//Fin de propiedad ComputerName.
        public string BuildNumber
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].BuildNumber;
                }//Fin de if.
                else
                {
                    return buildNumber;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].BuildNumber = value;
                }//Fin de if.
                else
                {
                    buildNumber = value;
                }//Fin de else.
                OnPropertyChanged("BuildNumber");
            }//Fin de set.
        }//Fin de propiedad BuildNumber.
        public string ModifiedTime
        {
            get
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    return this.Items[this.SelectedIndexOfCollection].ModifiedTime;
                }//Fin de if.
                else
                {
                    return modifiedTime;
                }//Fin de else.
            }//Fin de get.
            set
            {
                if (this.SelectedIndexOfCollection > -1)
                {
                    this.Items[this.SelectedIndexOfCollection].ModifiedTime = value;
                }//Fin de if.
                else
                {
                    modifiedTime = value;
                }//Fin de else.
                OnPropertyChanged("ModifiedTime");
            }//Fin de set.
        }//Fin de propiedad BuildNumber.
        */
        #endregion

        #endregion
        #region Interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }//Fin de if.
        }//Fin de OnPropertyChanged.
        #endregion
        //metodos o funciones
        #region Builders or Constructores
        public ProductKeyViewModel()
        {
            //There is take on the product key on the Windows 10
            string pk = "";
            string keyPath = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform\\";
            RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine,
                RegistryView.Registry64);
            RegistryKey rk1 = localKey.OpenSubKey(keyPath);
            
            pk = (string)rk1.GetValue("BackupProductKeyDefault");
            ProductKeyWin = pk;


        }
        #endregion
        #region methods 
        //estamos programando esta parte y no funciona logicamente
        private void ViewKeyProductKey()
        {
            //AddClientCommand = new CommandBase(param => this.AddClient());
            //ClearCommand = new CommandBase(new Action<Object>(ClearClient));
            
        }

        private void ExitProgram(object obj)
        {
            
        }
        #endregion
    }
}
