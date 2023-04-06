using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experimential_Software
{
    // Lớp đối tượng Line
    public class LineConnect 
    {
        private ConnectableE _startEPower;
        public ConnectableE StartEPower { get => _startEPower; set => _startEPower = value; }

        private ConnectableE _endEPower;
        public ConnectableE EndEPower { get => _endEPower; set => _endEPower = value; }

        // Beacuse line is child of pnlMain so Point coordinate pnlmain system 
        private Point _startPoint;
        private Point _endPoint;
        public Point StartPoint
        {
            get { return _startPoint; }
            set
            {
                _startPoint = value;
            }
        }

        public Point EndPoint
        {
            get { return _endPoint; }
            set
            {
                _endPoint = value;
            }
        }

        //Point Input is phead or pTail of ConnectableE
        public LineConnect(ConnectableE StartEPower, ConnectableE EndEPower, Point start, Point end, Panel pnlMain)
        {
            this._startEPower = StartEPower;
            this._endEPower = EndEPower;
            this._startPoint = start;
            this._endPoint = end;
        }

        public virtual Point TransferPointToMain(ConnectableE connectableE, Point point, Panel pnlMain)
        {
            Point pointToScreen = connectableE.PointToScreen(point);
            Point pointToMain = pnlMain.PointToClient(pointToScreen);

            return pointToMain;
        }
    }
}
