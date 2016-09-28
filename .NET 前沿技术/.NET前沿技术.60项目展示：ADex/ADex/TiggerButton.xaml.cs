using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ADex
{
	public partial class TiggerButton : UserControl
	{
        //依赖属性
	    public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number",
	                           typeof(int),
	                                 typeof(TiggerButton),
	                                new PropertyMetadata(1));

        public ADEntity ADE
        {
            get; set;
        }

        /// <summary>
        /// 在按钮上显示的数字
        /// </summary>
	    public int Number
	    {
	        get
	        {
	            return (int) GetValue(NumberProperty);
	        }
            set
            {
                SetValue(NumberProperty,value);
                tb_Number.Text = value.ToString();
            }
	    }

        /// <summary>
        /// 构造函数
        /// </summary>
        public TiggerButton(int number,ADEntity ade):this(number)
        {
            ADE = ade;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public TiggerButton(int number):this()
        {
            Number = number;
        }

		public TiggerButton()
		{
			InitializeComponent();
		}

        private void LayoutRoot_MouseEnter ( object sender, MouseEventArgs e )
        {
            //设置按钮背景透明度
            BackGroundRec.Opacity = 0.5;
        }

        private void LayoutRoot_MouseLeave ( object sender, MouseEventArgs e )
        {
            BackGroundRec.Opacity = 1;
        }

        /// <summary>
        /// 按钮被点击后触发
        /// </summary>
	    public event EventHandler onSelected;

        private void UserControl_MouseLeftButtonDown ( object sender, MouseButtonEventArgs e )
        {
            if (onSelected != null)
            {
                onSelected(this, null);
            }
        }
	}
}