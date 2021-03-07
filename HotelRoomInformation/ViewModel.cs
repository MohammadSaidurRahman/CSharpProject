using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HotelRoomInformation
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<Room> rooms;

        public Command NextRoom { get; private set; }
        public Command PreviousRoom { get; private set; }


        private int currentRoom;
        public ViewModel()
        {

            this.currentRoom = 0;
            this.IsAtStart = true;
            this.IsAtEnd = false;

            this.NextRoom = new Command(this.Next, () => this.rooms.Count > 1 && !this.IsAtEnd);

            this.PreviousRoom = new Command(this.Previous, () => this.rooms.Count > 0 && !this.IsAtStart);



            this.rooms = new List<Room>
            {
                new Room
                {
                    RoomID=1,
                    RoomNumber="101",
                    Price="200$",
                    RoomType="AC",
                    NumberOfBed="2",
                    IsBooked="Yes"
                },

                new Room
                {
                    RoomID=2,
                    RoomNumber="201",
                    Price="300$",
                    RoomType="AC",
                    NumberOfBed="3",
                    IsBooked="Yes"
                },

                new Room
                {
                    RoomID=3,
                    RoomNumber="301",
                    Price="100$",
                    RoomType="NON-AC",
                    NumberOfBed="2",
                    IsBooked="NO"
                }



            };
        }


        private bool _isAtStart;
        public bool IsAtStart
        {
            get => this._isAtStart;
            set
            {
                this._isAtStart = value;
                this.OnPropertyChanged(nameof(IsAtStart));
            }
        }

        private bool _isAtEnd;
        public bool IsAtEnd
        {
            get => this._isAtEnd;
            set
            {
                this._isAtEnd = value;
                this.OnPropertyChanged(nameof(IsAtEnd));
            }
        }


        public Room Current
        {
            get => this.rooms.Count > 0 ? this.rooms[currentRoom] : null;
        }

        private void Next()
        {
            if (this.rooms.Count - 1 > this.currentRoom)
            {
                this.currentRoom++;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtStart = false;
                this.IsAtEnd = (this.rooms.Count - 1 == this.currentRoom);
            }
        }

        private void Previous()
        {
            if (this.rooms.Count > 0)
            {
                this.currentRoom--;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtEnd = false;
                this.IsAtStart = (this.currentRoom == 0);
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
