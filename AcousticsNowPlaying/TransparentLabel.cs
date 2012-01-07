using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;


public class TransparentLabel : Label {
    public TransparentLabel() {
        this.SetStyle(ControlStyles.Opaque, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
    }
    protected override CreateParams CreateParams {
        get {
            CreateParams parms = base.CreateParams;
            parms.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
            return parms;
        }
    }
    protected override void OnPaint(PaintEventArgs e) {
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        Font font = new Font(this.Font.Name, this.Font.Size * 0.9f);
        /* Stroke */
        for (int i = -1; i < 2; ++i) {
            for (int j = -1; j < 2; ++j) {
                e.Graphics.DrawString(Text, font, Brushes.Black, i, j);
            }
        }
        /* Primary text */
        e.Graphics.DrawString(Text, font, Brushes.White, 0, 0);
    }

}
