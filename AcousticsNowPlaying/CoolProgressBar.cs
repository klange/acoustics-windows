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

        float percent = (float)(Value - Minimum) / (float)(Maximum - Minimum);

        // Draw the bar
        Draw3DBorder(g, 0.5f, Brushes.Black, true, 7.0f, 1.0f);
        
        Draw3DBorder(g, 3.5f, Brushes.White, true, 4.0f, percent);

        RenderText(g);

        Draw3DBorder(g, 3.5f, Brushes.White, false, 4.0f, 1.0f);

        // Clean up.
        g.Dispose();	
    }
    private void Draw3DBorder(Graphics g, float offset, Brush color, bool fill, float r, float percent) {
        int pen_width = 2;
        float x = this.ClientRectangle.Left + (pen_width / 2) + offset;
        float y = this.ClientRectangle.Top + (pen_width / 2) + offset;
        float w = (this.ClientRectangle.Width - (pen_width / 2 + 2 + offset * 2)) * percent;
        float h = this.ClientRectangle.Height - (pen_width / 2 + 2 + offset * 2);

        Pen pen = new Pen(color, (float)pen_width);
        GraphicsPath path = new GraphicsPath();

        if (w < 2 * r) {
            w = 2 * r;
        }

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
    private String timeToString(int time) {
        int hours = 0, minutes = 0, seconds = time;
        while (seconds > 3600) {
            hours++;
            seconds -= 3600;
        }
        while (seconds > 60) {
            minutes++;
            seconds -= 60;
        }
        if (hours == 0) {
            if (minutes == 0) {
                return String.Format("0:{0:00}", seconds);
            } else {
                return String.Format("{0}:{1:00}", minutes, seconds);
            }
        } else {
            return String.Format("{0}:{1:00}:{2:00}", hours, minutes, seconds);
        }
    }

    /*
    private void updateClock() {
        lblSongTime.Text = timeToString(coolProgressBar1.Value) + " / " + timeToString(coolProgressBar1.Maximum);
        lblSongTime.Refresh();
    }
     */
    private void RenderText(Graphics g) {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.CompositingQuality = CompositingQuality.HighQuality;
        g.CompositingMode = CompositingMode.SourceOver;

        String text = timeToString(this.Value) + " / " + timeToString(this.Maximum);

        GraphicsPath stroke = new GraphicsPath();
        stroke.AddString(text, this.Font.FontFamily, (int)FontStyle.Regular, this.Font.Size * 1.2f, new Point(0, 0), StringFormat.GenericDefault);
        RectangleF bounds = stroke.GetBounds();
        /* Align right */
        Matrix translationMatrix = new Matrix();
        translationMatrix.Translate((this.Width - bounds.Width - 8) / 2, (this.Height - bounds.Height - 5) / 2);
        stroke.Transform(translationMatrix);
        g.DrawPath(new Pen(Brushes.Black, 3.0f), stroke); /* Stroke */
        g.FillPath(Brushes.White, stroke); /* Text */
    }
	

}
