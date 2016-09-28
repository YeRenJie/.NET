using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Windows.Shapes;
using System.Windows.Media;

namespace ADex
{
    public partial class AD : UserControl
    {
        /// <summary>
        /// 幻灯片计时器
        /// </summary>
        DispatcherTimer timer;
        /// <summary>
        /// 记录当前显示的AD
        /// </summary>
        public ADEntity currentAD;

        /// <summary>
        /// 记录当前正在使用的Image
        /// </summary>
        Image currentImage;

        /// <summary>
        /// 当前正在显示的AD
        /// </summary>
        public ADEntity CurrentAD
        {
            get
            {
                return currentAD;
            }
            set
            {
                //外界可通过更改值,并显示替换图片的动态效果
                if (!currentAD.Equals(value))
                {
                    currentAD = value;
                    BeginAnim(value);
                }
            }
        }

        /// <summary>
        /// AD列表
        /// </summary>
        List<ADEntity> ads = new List<ADEntity>();

        /// <summary>
        /// 构造方法
        /// </summary>
        public AD(List<ADEntity> ADs)
            : this()
        {
            ads = ADs;
        }

        public AD()
        {
            InitializeComponent();
            //读取要显示的图片
            this.ads = ADXMLReader.GetADs();
            //初始化计时器
            timer = new DispatcherTimer();
            //计时器间隔5秒
            timer.Interval = new TimeSpan(0, 0, 0, 5);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int imgCount = ads.Count;
            for (int i = 0; i < imgCount; i++)
            {
                if (currentAD.Equals(ads[i]))
                {
                    //在计时器中循环替换当前AD
                    CurrentAD = ads[(i + 1) % ads.Count];
                    //当前色
                    Button btn = (Button)ButtonContainer.Children[Convert.ToInt16(CurrentAD.Id)];
                    btn.Background = new  SolidColorBrush(Colors.Yellow);
                    //上一个照片对应的按钮变红
                    if (Convert.ToInt16(CurrentAD.Id) > 0)
                    {
                        btn = (Button)ButtonContainer.Children[Convert.ToInt16(CurrentAD.Id) - 1];
                        btn.Background = new SolidColorBrush(Colors.Red);
                        btn.BorderBrush = new SolidColorBrush(Colors.Red);
                    }
                    else
                    {
                        btn = (Button)ButtonContainer.Children[ads.Count - 1];
                        btn.Background = new SolidColorBrush(Colors.Red);
                        btn.BorderBrush = new SolidColorBrush(Colors.Red);
                    }
                    break;
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ads.Count; i++)
            {
                //加载按钮
                Button b = new Button();
                b.Content = i + 1;
                b.Click += new RoutedEventHandler(tb_onSelected);
                b.Height = 20.0;
                b.Width = 20.0;
                b.MouseEnter += new System.Windows.Input.MouseEventHandler(b_MouseEnter);
                b.MouseLeave += new System.Windows.Input.MouseEventHandler(b_MouseLeave);
                ButtonContainer.Children.Add(b);
            }
            CurrentAD = ads[0];
            if (ads.Count > 0)
            {
                //为当前AD赋初始值
                currentAD = ads[0];
                Image1.Source = new BitmapImage(new Uri(currentAD.Image, UriKind.Relative));
               
                currentImage = Image1;
            }
           
        }

        void b_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.Opacity = 1;
        }

        void b_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button b = (Button)sender;
            
            b.Opacity = 0.5;
        }

      

        void tb_onSelected(object sender, EventArgs e)
        {
            ////按钮被选中后，替换当前AD
            CurrentAD = this.ads[Convert.ToInt32(((Button)sender).Content)-1];
            for (int i = 0; i < ads.Count; i++)
            {
                if (CurrentAD.Equals(ads[i]))
                {
                    Button tbutton = (Button)ButtonContainer.Children[Convert.ToInt16(CurrentAD.Id)] ;
                    tbutton.Background= new  SolidColorBrush(Colors.Yellow);
                    tbutton.BorderBrush = new  SolidColorBrush(Colors.Yellow);
                }
                else
                {
                    Button tbutton = (Button)ButtonContainer.Children[i];
                    tbutton.Background = new  SolidColorBrush(Colors.Red);
                    tbutton.BorderBrush = new  SolidColorBrush(Colors.Red);
                }
            }
            //重设计时器
            timer.Start();
        }

        /// <summary>
        /// 播放动画
        /// </summary>
        public void BeginAnim(ADEntity adEntity)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            //构造新故事版
            Storyboard sb_Opacity = new Storyboard();
            //图片隐藏动画
            DoubleAnimation ImageHideAnim = new DoubleAnimation();
            ImageHideAnim .To = 0;//透明度目标为0
            ImageHideAnim.From = 1;
            ImageHideAnim.Duration = new TimeSpan(0,0,1);//1秒动画时间           
            //图片显示动画
            DoubleAnimation ImageShowAnim = new DoubleAnimation();
            ImageShowAnim.To = 1;//透明度目标为1
            ImageShowAnim.From = 0;//透明度初始值为0
            ImageShowAnim.Duration = new TimeSpan(0,0,1);//时间线播放的时间长度
         
            //构造图片URI
            Uri uri = new Uri(adEntity.Image, UriKind.Relative);
            if (currentImage == Image1)
            {
                //为新图片赋值
                Image2.Source = new BitmapImage(uri);
                //设置动画对象
                Storyboard.SetTarget(ImageHideAnim, Image1);
                Storyboard.SetTarget(ImageShowAnim, Image2);
                //设置当前Image
                currentImage = Image2;
            }
            else if (currentImage == Image2)
            {
                Image1.Source = new BitmapImage(uri);
                Storyboard.SetTarget(ImageHideAnim, Image2);
                Storyboard.SetTarget(ImageShowAnim, Image1);
                currentImage = Image1;
            }

            //设置动画对象属性
            Storyboard.SetTargetProperty(ImageHideAnim, new PropertyPath("Opacity"));
            Storyboard.SetTargetProperty(ImageShowAnim, new PropertyPath("Opacity"));
            //把动画添加到故事版中
            sb_Opacity.Children.Add(ImageHideAnim);
            sb_Opacity.Children.Add(ImageShowAnim);
            try
            {
                //开始动画
                tb_Description.Text = adEntity.Description;
                sb_Opacity.Begin();
            }
            catch (Exception ex)
            {
                
            }

        }

        private void UserControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            /*   Storyboard sb = new Storyboard();
               DoubleAnimation da = new DoubleAnimation()
                                    {
                                        Duration = new TimeSpan(0,0,1),
                                        To = 1,
                                        From = ContainerGrid.Opacity
                                    };
               Storyboard.SetTarget(da, ContainerGrid);
               Storyboard.SetTargetProperty(da, new PropertyPath("Opacity"));
               sb.Children.Add(da);
               sb.Begin();*/
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            /*  Storyboard sb = new Storyboard();
              DoubleAnimation da = new DoubleAnimation
                                   {
                                       Duration = new TimeSpan(0,0,1),
                                       To = 0,
                                       From = ContainerGrid.Opacity
                                   };
              Storyboard.SetTarget(da, ContainerGrid);
              Storyboard.SetTargetProperty(da, new PropertyPath("Opacity"));
              sb.Children.Add(da);
              sb.Begin();*/
        }
    }
}