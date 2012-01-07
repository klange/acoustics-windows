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
    protected override void OnTextChanged(EventArgs e) {
        this.Invalidate();
        InvalidateEx();
        base.OnTextChanged(e);
    }
    protected override void OnPaintBackground(PaintEventArgs prevent) {
        /* Prevent Background Rendering */
    }
    protected void InvalidateEx() {
        if (Parent == null)
            return;
        Rectangle rc = new Rectangle(this.Location, this.Size);
        Parent.Invalidate(rc, true);
    }
    protected override void OnPaint(PaintEventArgs e) {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
        e.Graphics.CompositingMode = CompositingMode.SourceOver;
     
        GraphicsPath stroke = new GraphicsPath();
        stroke.AddString(this.Text, this.Font.FontFamily, (int)FontStyle.Regular, this.Font.Size * 1.2f, new Point(0, 0), StringFormat.GenericDefault);
        RectangleF bounds = stroke.GetBounds();
        if (this.TextAlign == ContentAlignment.TopRight) {
            /* Align right */
            Matrix translationMatrix = new Matrix();
            translationMatrix.Translate(this.Width - bounds.Width - 8, 0);
            stroke.Transform(translationMatrix);
        }
        e.Graphics.DrawPath(new Pen(Brushes.Black, 3.0f), stroke); /* Stroke */
        e.Graphics.FillPath(Brushes.White, stroke); /* Text */
    }

}
