using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Quiz
{

    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip |
                               ToolStripItemDesignerAvailability.ContextMenuStrip)]
    public class TrackBarMenuItem : ToolStripControlHost
    {
        private TrackBar trackBar;

        public TrackBarMenuItem() : base(new TrackBar())
        {
            this.trackBar = this.Control as TrackBar;

        }

        public int Value
        {
            get { return trackBar.Value; }
        }
    }
}

