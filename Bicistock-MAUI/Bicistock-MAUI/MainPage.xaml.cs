using Bicistock_MAUI.Bicistock_MAUI.Shared.Models;
using Bicistock_MAUI.Bicistock_MAUI.Shared.Services;
using System.ComponentModel;

namespace Bicistock_MAUI;

[DesignTimeVisible(false)]
public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        // Aquí asignas la lista de citas al ItemSource del CollectionView
        LoadAppointments();
    }

    private async void LoadAppointments()
    {
        AppointmentService appointmentService = new AppointmentService();
        List<Appointment> appointments = await appointmentService.GetHttpAppointments();
        Vista.ItemsSource = appointments;
    }

}

