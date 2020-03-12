using System;

namespace BlabberApp.Domain
{
    public class Blab : BaseEntity {
        private DateTime _dttm = DateTime.Now;
        public DateTime DTTM {
            get {return this._dttm;} 
            set {this._dttm = value;}
        }

        private string _message;
        public string Message {
            get {return this._message;}
            set {this._message = value;}
        }

        private string _userId;
        public string UserID {
            get {return this._userId;}
            set {this._userId = value;}
        }

        public Blab()
        {
            DTTM = DateTime.Now;
        }
    }
}