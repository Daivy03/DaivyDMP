using Android.Content;
using Android.Widget;
using UventoXF.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(PdfViewerService))]
public class PdfViewerService : IPdfViewer
{
    public void ShowDocument(string filePath)
    {
        var context = Android.App.Application.Context;
        var file = new Java.IO.File(filePath);
        var uri = Android.Net.Uri.FromFile(file);

        var intent = new Intent(Intent.ActionView);
        intent.SetDataAndType(uri, "application/pdf");
        intent.SetFlags(ActivityFlags.ClearWhenTaskReset | ActivityFlags.NewTask);

        try
        {
            context.StartActivity(intent);
        }
        catch (ActivityNotFoundException)
        {
            Toast.MakeText(context, "Nessuna app per la visualizzazione PDF trovata.", ToastLength.Long).Show();
        }
    }
}
