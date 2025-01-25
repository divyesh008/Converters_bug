using System.Collections.ObjectModel;
using System.Windows.Input;
using poc_maui.Models;

namespace poc_maui.Views.SubViews;

public partial class AttachmentList : ContentView
{
    public AttachmentList()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty AttachmentsProperty =
    BindableProperty.Create(nameof(Attachments), typeof(ObservableCollection<AttachmentViewModel>), typeof(AttachmentList), default(ObservableCollection<AttachmentViewModel>));
    public ObservableCollection<AttachmentViewModel> Attachments
    {
        get => (ObservableCollection<AttachmentViewModel>)GetValue(AttachmentsProperty);
        set => SetValue(AttachmentsProperty, value);
    }

    public static readonly BindableProperty IsEditableProperty =
    BindableProperty.Create(nameof(IsEditable), typeof(bool), typeof(AttachmentList), default(bool));
    public bool IsEditable
    {
        get => (bool)GetValue(IsEditableProperty);
        set => SetValue(IsEditableProperty, value);
    }

    public static readonly BindableProperty AttachmentDeleteCommandProperty =
    BindableProperty.Create(nameof(AttachmentDeleteCommand), typeof(ICommand), typeof(AttachmentList), null);

    public ICommand AttachmentDeleteCommand
    {
        get => (ICommand)GetValue(AttachmentDeleteCommandProperty);
        set => SetValue(AttachmentDeleteCommandProperty, value);
    }

    public static readonly BindableProperty HasDataProperty =
       BindableProperty.Create(
           nameof(HasData),
           typeof(bool),
           typeof(AttachmentList),
           defaultValue: false);

    public bool HasData
    {
        get => (bool)GetValue(HasDataProperty);
        set => SetValue(HasDataProperty, value);
    }
}
