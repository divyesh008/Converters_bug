using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using poc_maui.Models;

namespace poc_maui.ViewModels
{
    public class AttachmentsPageViewModel : BaseViewModel
    {
        public ICommand AttachmentDeleteCommand => new Command<AttachmentViewModel>(async (attachment) => await DeleteAttachment(attachment));
        public ICommand ToggleEditModeCommand => new Command(ToggleEditMode);
        public ICommand ToggleDataCommand => new Command(ToggleData);

        public AttachmentsPageViewModel()
        {
        }

        public ObservableCollection<AttachmentViewModel> AttachmentList
        {
            get { return _attachmentList; }
            set { _attachmentList = value; OnPropertyChanged(nameof(AttachmentList)); }
        }
        private ObservableCollection<AttachmentViewModel> _attachmentList;

        public bool IsAttachmentsEditable
        {
            get { return _isAttachmentsEditable; }
            set { _isAttachmentsEditable = value; OnPropertyChanged(nameof(IsAttachmentsEditable)); }
        }
        private bool _isAttachmentsEditable;

        public bool IsAttachmentsHasData
        {
            get { return _isAttachmentsHasData; }
            set { _isAttachmentsHasData = value; OnPropertyChanged(nameof(IsAttachmentsHasData)); }
        }
        private bool _isAttachmentsHasData;

        private async Task DeleteAttachment(AttachmentViewModel attachment)
        {
            AttachmentList.Remove(attachment);
            IsAttachmentsHasData = AttachmentList.Any();
            OnPropertyChanged(nameof(AttachmentList));
            IToast searchMessageToast = Toast.Make($"Deleted Attachment {attachment.FileName}", ToastDuration.Short);
            await searchMessageToast.Show();
        }

        private void ToggleEditMode()
        {
            IsAttachmentsEditable = !IsAttachmentsEditable;
        }

        private void ToggleData()
        {
            if (AttachmentList != null && AttachmentList.Any())
            {
                AttachmentList = new ObservableCollection<AttachmentViewModel>();
            }
            else
            {
                AttachmentList = new ObservableCollection<AttachmentViewModel>()
                {
                    new AttachmentViewModel
                    {
                        FileName = "Models.pdf",
                        UploadedDate = new DateTime(2018, 07, 21, 13, 22, 00),
                        AttachmentGroupName = "Back office",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    },
                    new AttachmentViewModel
                    {
                        FileName = "Blueprints.pdf",
                        UploadedDate = new DateTime(2018, 07, 21, 13, 25, 00),
                        AttachmentGroupName = "Back Office",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    },
                };
            }
            IsAttachmentsHasData = AttachmentList.Any();
        }
    }
}

