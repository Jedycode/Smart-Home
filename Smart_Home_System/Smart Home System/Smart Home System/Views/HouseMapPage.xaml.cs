using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp.Views.Forms;
using SkiaSharp;

namespace Smart_Home_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HouseMapPage : ContentPage
    {
        public HouseMapPage()
        {
            InitializeComponent();
        }

        private void canvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.BlueViolet);
            canvas.Translate(100, 0);
            SKPaint thinLinePaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Black,
                StrokeWidth = 15
            };
            SKPaint rectPaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Black,
                StrokeWidth = 15
            };
            SKPaint thickLinePaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Orange,
                StrokeWidth = 18
            };
            SKPaint staticDoorLinePaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Blue,
                StrokeWidth = 18
            };
            SKPaint activeDoorLinePaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Green,
                StrokeWidth = 18
            };
            //Main House
            canvas.DrawRect(30, 120, info.Width - 70, info.Height-550, rectPaint);
            //Garage
            canvas.DrawRect(780, 600, 260, 550, rectPaint);
            //Kitchen
            canvas.DrawRect(30, 600, 350, 550, rectPaint);
            //Kids room
            canvas.DrawRect(30, 120, 350, 480, rectPaint);
            //Bedroom
            canvas.DrawRect(780, 120, 260, 480, rectPaint);
            //Bathroom
            canvas.DrawRect(380, 120, 400, 230, rectPaint);
            //Living room
            canvas.DrawRect(380, 600, 400, 550, rectPaint);
            //Kids room west window
            canvas.DrawLine(30, 250, 30, 350, thickLinePaint);
            //Kitchen west window
            canvas.DrawLine(30, 780, 30, 890, thickLinePaint);
            //Bedroom north window
            canvas.DrawLine(880, 120, 960, 120, thickLinePaint);
            //Kitchen south window
            canvas.DrawLine(120, info.Height - 430, 210, info.Height - 430, thickLinePaint);
            //Living room south window
            canvas.DrawLine(640, info.Height - 430, 730, info.Height - 430, thickLinePaint);
            //Kitchen door
            canvas.DrawLine(380, 800, 380, 850, staticDoorLinePaint);
            //Main door
            canvas.DrawLine(520, info.Height - 430, 570, info.Height - 430, activeDoorLinePaint);
            //Kids room door
            canvas.DrawLine(380, 430, 380, 480, staticDoorLinePaint);
            //Garage door
            canvas.DrawLine(880, info.Height - 430, 970, info.Height - 430, activeDoorLinePaint);





        }
    }
}