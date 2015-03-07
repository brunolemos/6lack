using Slack.Common;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace Slack.Utils
{
    public class AppSettings : AppSettingsBase
    {
        public static readonly AppSettings Instance = new AppSettings();

        public override uint Version { get { return VERSION; } }
        private const uint VERSION = 1;

        private const string COLUMNS_KEY = "COLUMNS";
        private const int COLUMNS_DEFAULT = 2;

        private AppSettings()
        {
        }

        public override void Up()
        {
        }

        public override void Down()
        {
        }

        public int Columns
        {
            get { return GetValueOrDefault(COLUMNS_KEY, COLUMNS_DEFAULT); }

            set
            {
                if (!(value >= 1 && value <= 4)) value = COLUMNS_DEFAULT;

                if (SetValue<int>(COLUMNS_KEY, value))
                {
                    //var handler = ColumnsChanged;
                    //if (handler != null) handler(this, new ColumnsEventArgs(value));
                }
            }
        }

        //public async Task<Notes> LoadNotes() { return await ReadFileOrDefault(NOTES_FILENAME, NOTES_DEFAULT); }
        //public async Task<bool> SaveNotes(Notes notes) {
        //    var success = await SaveFile(NOTES_FILENAME, notes);

        //    if(success)
        //    {
        //        var handler = NotesSaved;
        //        if (handler != null) handler(this, EventArgs.Empty);
        //    }

        //    return success;
        //}

        //public async Task<Notes> LoadArchivedNotes() { return await ReadFileOrDefault(ARCHIVED_NOTES_FILENAME, ARCHIVED_NOTES_DEFAULT); }
        //public async Task<bool> SaveArchivedNotes(Notes notes)
        //{
        //    var success = await SaveFile(ARCHIVED_NOTES_FILENAME, notes);

        //    if (success)
        //    {
        //        var handler = ArchivedNotesSaved;
        //        if (handler != null) handler(this, EventArgs.Empty);
        //    }

        //    return success;
        //}
    }
}