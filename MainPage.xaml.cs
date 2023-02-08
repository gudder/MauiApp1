namespace App1;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (scale_slider == null) return;
        if (scale_slider.Value - 10 > scale_slider.Minimum)
            scale_slider.Value -= 10;
        else
            scale_slider.Value = scale_slider.Minimum;
    }

    private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (scale_slider == null) return;
        if (scale_slider.Value + 10 < scale_slider.Maximum)
            scale_slider.Value += 10;
        else
            scale_slider.Value = scale_slider.Maximum;
    }

    private void CheckZoomButtom()
    {
        if (scale_slider == null) return;
        if (scale_slider.Value >= scale_slider.Maximum)
        {
            btn_zoom_in.IsEnabled = false;
        }
        else if (scale_slider.Value <= scale_slider.Minimum)
        {
            btn_zoom_out.IsEnabled = false;
        }
        else
        {
            btn_zoom_in.IsEnabled = true;
            btn_zoom_out.IsEnabled = true;
        }
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        CheckZoomButtom();
    }
}

