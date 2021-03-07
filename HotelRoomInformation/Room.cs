using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HotelRoomInformation
{
    public class Room : INotifyPropertyChanged
    {
        public int _roomID;
        public int RoomID
        {
            get => this._roomID;
            set
            {
                this._roomID = value;
                this.OnPropertyChanged(nameof(RoomID));
            }
        }

        public string _roomNumber;
        public string RoomNumber
        {
            get => this._roomNumber;
            set
            {
                this._roomNumber = value;
                this.OnPropertyChanged(nameof(RoomNumber));

            }
        }

        public string _price;
        public string Price
        {
            get => this._price;
            set
            {
                this._price = value;
                this.OnPropertyChanged(nameof(Price));

            }
        }


        public string _roomType;
        public string RoomType
        {
            get => this._roomType;
            set
            {
                this._roomType = value;
                this.OnPropertyChanged(nameof(RoomType));

            }
        }

        public string _numberOfBed;
        public string NumberOfBed
        {
            get => this._numberOfBed;
            set
            {
                this._numberOfBed = value;
                this.OnPropertyChanged(nameof(NumberOfBed));

            }
        }

        public string _isBooked;


        public string IsBooked
        {
            get => this._isBooked;
            set
            {
                this._isBooked = value;
                this.OnPropertyChanged(nameof(IsBooked));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
