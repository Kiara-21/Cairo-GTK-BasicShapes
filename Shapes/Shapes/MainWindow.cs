using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void drawRectangle(object sender, EventArgs e)
    {
        new cRectangle(); //draw it
    }

    protected void drawSquare(object sender, EventArgs e)
    {
        new cSquare(); 
    }

    protected void drawCircle(object sender, EventArgs e)
    {
        new cCircle();
    }

    protected void drawSegment(object sender, EventArgs e)
    {
        new cSegment();
    }

    protected void drawLine(object sender, EventArgs e)
    {
        new cLine();
    }

    protected void drawParallel(object sender, EventArgs e)
    {
        new cParallel();
    }

    protected void drawTriangle(object sender, EventArgs e)
    {
        new cTriangle();
    }

    protected void drawCurve(object sender, EventArgs e)
    {
        new cCurve();
    }
}


class cRectangle : Window
{
    public cRectangle():base ("rectangle")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.Rectangle(100, 50, 100, 50); // our rectangle, his size: 100*50

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cSquare : Window
{
    public cSquare() : base("square")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.Rectangle(50, 50, 50, 50); // our square, his size: 50*50

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cCircle : Window
{
    public cCircle() : base("circle")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.Arc(100, 90, 70, 0, 2 * Math.PI); // our circle, his size 70

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cSegment : Window 
{
    public cSegment() : base("circle segment")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.Arc(100, 90, 70, 10, 2 * Math.PI); // our circle segment

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cLine : Window 
{
    public cLine() : base("line")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.LineTo(100, 50); //first point
        shape.LineTo(300, 90); // second point

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cParallel : Window
{
    public cParallel() : base("parallel lines")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.MoveTo(70, 90);
        shape.LineTo(250, 90); //first line
        shape.MoveTo(70, 180);
        shape.LineTo(250, 180); //second line

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cTriangle : Window
{
    public cTriangle() : base("triangle")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.MoveTo(50, 50);
        shape.LineTo(100, 50);
        shape.LineTo(100, 100); //draw triangle using lines

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}

class cCurve : Window
{
    public cCurve() : base("curve")
    {
        SetDefaultSize(500, 500); //set the window size
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };

        //create a place for drawing
        DrawingArea drawarea = new DrawingArea();
        drawarea.ExposeEvent += LetsDraw;

        Add(drawarea);
        ShowAll();
    }

    void LetsDraw(object sender, ExposeEventArgs args)
    {
        DrawingArea darea = (DrawingArea)sender;
        Cairo.Context shape = Gdk.CairoHelper.Create(darea.GdkWindow);

        //Write the shape code
        shape.SetSourceRGB(0.2, 0.5, 0.7); // set the color
        shape.MoveTo(25, 130);
        shape.CurveTo(100, 235, 165, 25, 255, 130); //our curve line

        shape.StrokePreserve();
        shape.Fill();

        ((IDisposable)shape).Dispose();
    }
}