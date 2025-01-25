using System;
namespace poc_maui.Models
{
	public class AttachmentViewModel
	{
		public string AttachmentId { get; set; }
        public string FileName { get; set; }
        public DateTime? UploadedDate { get; set; }
        public string UploadedBy { get; set; }
        public string AttachmentGroupId { get; set; }
        public string AttachmentGroupName { get; set; }
        public string ParentId { get; set; }
        public string FileExtension { get; set; }
        public string ThumbnailUrl { get; set; }
        public string FilePath { get; set; }
        public string DeviceFilePath { get; set; }
        public string Notes { get; set; }
        public string ImageFilePath { get; set; }
    }
}

