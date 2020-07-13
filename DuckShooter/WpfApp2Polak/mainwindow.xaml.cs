using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2Polak
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class mainwindow : Window
    {
        int Points = 0;
        int s1 = 1; //duck1 speed
        int s2 = 1;
        int s3 = 1;

        public mainwindow()
        {
            
            InitializeComponent();
           // var point = Mouse.GetPosition();
            //Point pointToWindow = Mouse.GetPosition(this);           // MouseX = point.X;            //MouseY = point.Y;            System.Windows.Threading.DispatcherTimer dispatcherTimer = new
        
            System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick; //event!!
            dispatcherTimer.Interval = new TimeSpan(20, 0, 0);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1);
            dispatcherTimer.Start();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
           // var point = Mouse.GetPosition(this);
           // GunSight.Margin = new Thickness(point.X, point.Y, 0, 0);
            Duck1.Margin = new Thickness(Duck1.Margin.Left - s1, Duck1.Margin.Top, 0, 0);
            Duck2.Margin = new Thickness(Duck2.Margin.Left - s2, Duck2.Margin.Top, 0, 0);
            Duck3.Margin = new Thickness(Duck3.Margin.Left - s3, Duck3.Margin.Top, 0, 0);

            if (Duck1.Margin.Left < -Duck1.Width ) //D1 left side
            {
                Duck1.Margin = new Thickness(-Duck1.Width, Duck1.Margin.Top, 0, 0);
                s1 = -s1;
                //Flip
                Duck1.RenderTransformOrigin = new Point(0.5, 0.5);
                ScaleTransform flipTrans = new ScaleTransform();
                flipTrans.ScaleX = -1;
                Duck1.RenderTransform = flipTrans;
            }

            if (Duck1.Margin.Left > Width) //D1 right side
            {
                Duck1.Margin = new Thickness(Width, Duck1.Margin.Top, 0, 0);
                s1 = -s1;
                //Flip
                Duck1.RenderTransformOrigin = new Point(0.5, 0.5);
                ScaleTransform flipTrans = new ScaleTransform();
                flipTrans.ScaleX = 1;
                Duck1.RenderTransform = flipTrans;
            }

            //DUCK 2
            if (Duck2.Margin.Left < -Duck2.Width) //D2 left side
            {
                //d1 = false;
                Duck2.Margin = new Thickness(-Duck2.Width, Duck2.Margin.Top, 0, 0);
                s2 = -s2;
                //Flip
                Duck1.RenderTransformOrigin = new Point(0.5, 0.5);
                ScaleTransform flipTrans = new ScaleTransform();
                flipTrans.ScaleX = -1;
                Duck2.RenderTransform = flipTrans;
            }

            if (Duck2.Margin.Left > Width) //D2 right side
            {
                //d1 = true;
                Duck2.Margin = new Thickness(Width, Duck2.Margin.Top, 0, 0);
                s2 = -s2;
                //Flip
                Duck2.RenderTransformOrigin = new Point(0.5, 0.5);
                ScaleTransform flipTrans = new ScaleTransform();
                flipTrans.ScaleX = 1;
                Duck2.RenderTransform = flipTrans;
            }

            //DUCK 3
            if (Duck3.Margin.Left < -Duck3.Width) //D3 Left side
            {
                //d1 = false;
                Duck3.Margin = new Thickness(-Duck3.Width, Duck3.Margin.Top, 0, 0);
                s3 = -s3;
                //Flip
                Duck3.RenderTransformOrigin = new Point(0.5, 0.5);
                ScaleTransform flipTrans = new ScaleTransform();
                flipTrans.ScaleX = -1;
                Duck3.RenderTransform = flipTrans;
            }

            if (Duck3.Margin.Left > Width) //D3 right side
            {
                //d1 = true;
                Duck3.Margin = new Thickness(Width, Duck3.Margin.Top, 0, 0);
                s3 = -s3;
                //Flip
                Duck3.RenderTransformOrigin = new Point(0.5, 0.5);
                ScaleTransform flipTrans = new ScaleTransform();
                flipTrans.ScaleX = 1;
                Duck3.RenderTransform = flipTrans;
            }
            //Counter.Content = "Counter:" + Duck1.Margin.Left;
        }

        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            // Get the x and y coordinates of the mouse pointer.
            System.Windows.Point position = e.GetPosition(this);
            double pX = position.X;
            double pY = position.Y;

            GunSight.Margin = new Thickness(pX - GunSight.Width/2, pY - GunSight.Height/2, 0, 0);
            // Sets the Height/Width of the circle to the mouse coordinates.
            // ellipse.Width = pX;
            // ellipse.Height = pY;
            
        }



        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if ( Math.Abs(GunSight.Margin.Left - Duck1.Margin.Left) < Duck1.Width/3 
                && Math.Abs(GunSight.Margin.Top - Duck1.Margin.Top) < Duck1.Height/3)
            {
                Points += 1;
                Counter.Content = "Counter:" + Points;
                if (s1 > 0)
                {
                    //d1 = false;
                    Duck1.Margin = new Thickness(-Duck1.Width, Duck1.Margin.Top, 0, 0);
                    s1 = -s1;
                    //Flip
                    Duck1.RenderTransformOrigin = new Point(0.5, 0.5);
                    ScaleTransform flipTrans = new ScaleTransform();
                    flipTrans.ScaleX = -1;
                    Duck1.RenderTransform = flipTrans;
                }
                else
                {
                    //d1 = true;
                    Duck1.Margin = new Thickness(Width, Duck1.Margin.Top, 0, 0);
                    s1 = -s1;
                    //Flip
                    Duck1.RenderTransformOrigin = new Point(0.5, 0.5);
                    ScaleTransform flipTrans = new ScaleTransform();
                    flipTrans.ScaleX = 1;
                    Duck1.RenderTransform = flipTrans;
                }
                
            }

            if (Math.Abs(GunSight.Margin.Left - Duck2.Margin.Left) < Duck2.Width / 3
                && Math.Abs(GunSight.Margin.Top - Duck2.Margin.Top) < Duck2.Height / 3)
            {
                Points += 1;
                Counter.Content = "Counter:" + Points;
                if (s2 > 0)
                {
                    //d1 = false;
                    Duck2.Margin = new Thickness(-Duck2.Width, Duck2.Margin.Top, 0, 0);
                    s2 = -s2;
                    //Flip
                    Duck1.RenderTransformOrigin = new Point(0.5, 0.5);
                    ScaleTransform flipTrans = new ScaleTransform();
                    flipTrans.ScaleX = -1;
                    Duck2.RenderTransform = flipTrans;
                }
                else
                {
                    //d1 = true;
                    Duck2.Margin = new Thickness(Width, Duck2.Margin.Top, 0, 0);
                    s2 = -s2;
                    //Flip
                    Duck2.RenderTransformOrigin = new Point(0.5, 0.5);
                    ScaleTransform flipTrans = new ScaleTransform();
                    flipTrans.ScaleX = 1;
                    Duck2.RenderTransform = flipTrans;
                }
            }

            if (Math.Abs(GunSight.Margin.Left - Duck3.Margin.Left) < Duck3.Width / 3
                && Math.Abs(GunSight.Margin.Top - Duck3.Margin.Top) < Duck3.Height / 3)
            {
                Points += 1;
                Counter.Content = "Counter:" + Points;
                if (s3 > 0)
                {
                    //d1 = false;
                    Duck3.Margin = new Thickness(-Duck3.Width, Duck3.Margin.Top, 0, 0);
                    s3 = -s3;
                    //Flip
                    Duck3.RenderTransformOrigin = new Point(0.5, 0.5);
                    ScaleTransform flipTrans = new ScaleTransform();
                    flipTrans.ScaleX = -1;
                    Duck3.RenderTransform = flipTrans;
                }
                else
                {
                    //d1 = true;
                    Duck3.Margin = new Thickness(Width, Duck3.Margin.Top, 0, 0);
                    s3 = -s3;
                    //Flip
                    Duck3.RenderTransformOrigin = new Point(0.5, 0.5);
                    ScaleTransform flipTrans = new ScaleTransform();
                    flipTrans.ScaleX = 1;
                    Duck3.RenderTransform = flipTrans;
                }
            }


        }

        
    }
}

