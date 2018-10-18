using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class ProductKey : NotifyBase
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
                OnPropertyChanged("Id");

            }
        }
        public string ProductName
        {
            get
            {
                return ProductName;
            }
            set
            {
                ProductName = value;
                OnPropertyChanged("ProductName");

            }
        }
        public string ProductId
        {
            get
            {
                return ProductId;
            }
            set
            {
                ProductId = value;
                OnPropertyChanged("ProductId");

            }
        }
        public string ProductKeyWin
        {
            get
            {
                return ProductKeyWin;
            }
            set
            {
                ProductKeyWin = value;
                OnPropertyChanged("ProductKeyWin");

            }
        }
        public string InstallationFolder
        {
            get
            {
                return InstallationFolder;
            }
            set
            {
                InstallationFolder = value;
                OnPropertyChanged("InstallationFolder");

            }
        }
        public string ComputerName
        {
            get
            {
                return ComputerName;
            }
            set
            {
                ComputerName = value;
                OnPropertyChanged("ComputerName");

            }
        }
        public string BuildNumber
        {
            get
            {
                return BuildNumber;
            }
            set
            {
                BuildNumber = value;
                OnPropertyChanged("BuildNumber");

            }
        }
        public string ModifiedTime
        {
            get
            {
                return ModifiedTime;
            }
            set
            {
                ModifiedTime = value;
                OnPropertyChanged("ModifiedTime");

            }
        }
       
        
    }
}
