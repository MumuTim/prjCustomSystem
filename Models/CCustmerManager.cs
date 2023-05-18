using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCustomSystem.Models
{
    public class CCustmerManager
    {
        List<CCustumer> _list = new List<CCustumer>();
        int _position = -1;
        public event Ddatamove Datamoved;
        public CCustmerManager()//使用建構子讓loaddata不用呼叫就自動執行
            {
            loadData();
            }
        private void loadData()
        {
            CCustumer x = new CCustumer();
            x.id = "001";
            x.name = "Andy";
            x.phone = "0988123456";
            x.email = "Andy@gmail.com";
            x.address = "Taipei";
            x.消費金額累積 = 317.5;
            _list.Add(x);

            x = new CCustumer();
            x.id = "002";
            x.name = "Jack";
            x.phone = "0988777888";
            x.email = "Jack@gmail.com";
            x.address = "Taipei";
            x.消費金額累積 = 988.5;
            _list.Add(x);

            x = new CCustumer();
            x.id = "025";
            x.name = "Mary";
            x.phone = "0988777999";
            x.email = "Mary@gmail.com";
            x.address = "Taipei";
            x.消費金額累積 = 1280;
            _list.Add(x);
        }
        public void moveFirst()
        {
            _position = 0;
            if(Datamoved!=null)
            Datamoved();
        }

        public void movePre()
        {
            if (_position > 0)
            {
                _position--;
            }
            else
            {
                _position = 0;
            }
            if (Datamoved != null)
                Datamoved();
        }

        public void moveNext()
        {
            if (_position < _list.Count - 1)
            {
                _position++;
            }
            else
            {
                _position = _list.Count - 1;
            }
            if (Datamoved != null)
                Datamoved();
        }

        public void moveLast()
        {
            _position = _list.Count - 1;
            if (Datamoved != null)
                Datamoved();
        }

        public void moveTo(int to)
        {
            _position = to - 1;
            if (_position > _list.Count - 1)
                _position = _list.Count - 1;
            if (Datamoved != null)
                Datamoved();
        }

        public void search(string input)
        {
            _position = _list.FindIndex(c => c.id == input);
            if (Datamoved != null)
                Datamoved();
        }

        public CCustumer current 
        {
            get { return _list[_position]; }
        }
        public List<CCustumer> all
        { get { return _list; } }
    }
}
