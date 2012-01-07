using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;


public class CoolProgressBar : Label {

    public int Minimum = 0;
    public int Maximum = 100;
    public int Value = 0;

    public CoolProgressBar() {
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
        Graphics g = e.Graphics;

        SolidBrush brush = new SolidBrush(Color.White);
        float percent = (float)(Value - Minimum) / (float)(Maximum - Minimum);
        Rectangle rect = this.ClientRectangle;

        // Calculate area for drawing the progress.
        rect.X += 2;
        rect.Y += 2;
        rect.Width -= 4;
        rect.Height -= 4;
        rect.Width = (int)((float)rect.Width * percent);


        // Draw a three-dimensional border around the control.
        Draw3DBorder(g, 0.5f, Brushes.Black, true);
        Draw3DBorder(g, 0.5f, Brushes.White, false);

        // Draw the progress meter.
        g.FillRectangle(brush, rect);

        // Clean up.
        brush.Dispose();
        g.Dispose();	
    }
    private void Draw3DBorder(Graphics g, float offset, Brush color, bool fill) {
        int pen_width = 2;
        float x = this.ClientRectangle.Left + (pen_width / 2) + offset;
        float y = this.ClientRectangle.Top + (pen_width / 2) + offset;
        float w = this.ClientRectangle.Width - (pen_width / 2 + 2 + offset * 2);
        float h = this.ClientRectangle.Height - (pen_width / 2 + 2 + offset * 2);
        float r = 4;

        Pen pen = new Pen(color, (float)pen_width);

        GraphicsPath path = new GraphicsPath();
        path.AddLine(x + r, y, x + (w - r * 2), y);
        path.AddArc(x + w - r * 2, y, r * 2, r * 2, 270, 90);
        path.AddLine(x + w, y + r, x + w, y + h - r * 2);
        path.AddArc(x + w - r * 2, y + h - r * 2, r * 2, r * 2, 0, 90);
        path.AddLine(x + w - r * 2, y + h, x + r, y + h);
        path.AddArc(x, y + h - r * 2, r * 2, r * 2, 90, 90);
        path.AddLine(x, y + h - r * 2, x, y + r);
        path.AddArc(x, y, r * 2, r * 2, 180, 90);
        path.CloseFigure();

        g.SmoothingMode = SmoothingMode.AntiAlias;
        if (fill) {
            g.FillPath(color, path);
        } else {
            g.DrawPath(pen, path);
        }
        
    } 
	

}
