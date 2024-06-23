namespace grid
{
    public partial class MainPage : ContentPage
    {

        String pic1str = "p1.jpg";
        String pic2str = "p2.jpg";
        String pic3str = "p3.jpg";
        String pic4str = "p4.jpg";
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            p11.Source = pic1str;
            p22.Source = pic2str;
            p33.Source = pic3str;
            p44.Source = pic4str;
            String temp;
            temp= pic3str;
            pic3str= pic4str;
            pic4str= pic2str;
            pic2str= pic1str;
            pic1str= temp;
        }
    }
    }


