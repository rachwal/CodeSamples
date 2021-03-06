// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

using System.Collections.Generic;
using System.Linq;

namespace DataTable.DataRepository
{
    public class DataRepositoryMock : IDataRepository
    {
        private List<DataTableEntry> mockData = new List<DataTableEntry>
        {
            new DataTableEntry("Trident", "Internet Explorer 4.0", "Win 95+", "4", "X"),
            new DataTableEntry("Trident",
                "Internet Explorer 5.0",
                "Win 95+",
                "5",
                "C"),
            new DataTableEntry("Trident",
                "Internet Explorer 5.5",
                "Win 95+",
                "5.5",
                "A"),
            new DataTableEntry("Trident",
                "Internet Explorer 6",
                "Win 98+",
                "6",
                "A"),
            new DataTableEntry("Trident",
                "Internet Explorer 7",
                "Win XP SP2+",
                "7",
                "A"),
            new DataTableEntry("Trident",
                "AOL browser (AOL desktop)",
                "Win XP",
                "6",
                "A"),
            new DataTableEntry("Gecko",
                "Firefox 1.0",
                "Win 98+ / OSX.2+",
                "1.7",
                "A"),
            new DataTableEntry("Gecko",
                "Firefox 1.5",
                "Win 98+ / OSX.2+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Firefox 2.0",
                "Win 98+ / OSX.2+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Firefox 3.0",
                "Win 2k+ / OSX.3+",
                "1.9",
                "A"),
            new DataTableEntry("Gecko",
                "Camino 1.0",
                "OSX.2+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Camino 1.5",
                "OSX.3+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Netscape 7.2",
                "Win 95+ / Mac OS 8.6-9.2",
                "1.7",
                "A"),
            new DataTableEntry("Gecko",
                "Netscape Browser 8",
                "Win 98SE+",
                "1.7",
                "A"),
            new DataTableEntry("Gecko",
                "Netscape Navigator 9",
                "Win 98+ / OSX.2+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.0",
                "Win 95+ / OSX.1+",
                "1",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.1",
                "Win 95+ / OSX.1+",
                "1.1",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.2",
                "Win 95+ / OSX.1+",
                "1.2",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.3",
                "Win 95+ / OSX.1+",
                "1.3",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.4",
                "Win 95+ / OSX.1+",
                "1.4",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.5",
                "Win 95+ / OSX.1+",
                "1.5",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.6",
                "Win 95+ / OSX.1+",
                "1.6",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.7",
                "Win 98+ / OSX.1+",
                "1.7",
                "A"),
            new DataTableEntry("Gecko",
                "Mozilla 1.8",
                "Win 98+ / OSX.1+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Seamonkey 1.1",
                "Win 98+ / OSX.2+",
                "1.8",
                "A"),
            new DataTableEntry("Gecko",
                "Epiphany 2.20",
                "Gnome",
                "1.8",
                "A"),
            new DataTableEntry("Webkit",
                "Safari 1.2",
                "OSX.3",
                "125.5",
                "A"),
            new DataTableEntry("Webkit",
                "Safari 1.3",
                "OSX.3",
                "312.8",
                "A"),
            new DataTableEntry("Webkit",
                "Safari 2.0",
                "OSX.4+",
                "419.3",
                "A"),
            new DataTableEntry("Webkit",
                "Safari 3.0",
                "OSX.4+",
                "522.1",
                "A"),
            new DataTableEntry("Webkit",
                "OmniWeb 5.5",
                "OSX.4+",
                "420",
                "A"),
            new DataTableEntry("Webkit",
                "iPod Touch / iPhone",
                "iPod",
                "420.1",
                "A"),
            new DataTableEntry("Webkit",
                "S60",
                "S60",
                "413",
                "A"),
            new DataTableEntry("Presto",
                "Opera 7.0",
                "Win 95+ / OSX.1+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera 7.5",
                "Win 95+ / OSX.2+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera 8.0",
                "Win 95+ / OSX.2+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera 8.5",
                "Win 95+ / OSX.2+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera 9.0",
                "Win 95+ / OSX.3+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera 9.2",
                "Win 88+ / OSX.3+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera 9.5",
                "Win 88+ / OSX.3+",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Opera for Wii",
                "Wii",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Nokia N800",
                "N800",
                "-",
                "A"),
            new DataTableEntry("Presto",
                "Nintendo DS browser",
                "Nintendo DS",
                "8.5",
                "C/A 1"),
            new DataTableEntry("KHTML",
                "Konqureror 3.1",
                "KDE 3.1",
                "3.1",
                "C"),
            new DataTableEntry("KHTML",
                "Konqureror 3.3",
                "KDE 3.3",
                "3.3",
                "A"),
            new DataTableEntry("KHTML",
                "Konqureror 3.5",
                "KDE 3.5",
                "3.5",
                "A"),
            new DataTableEntry("Tasman",
                "Internet Explorer 4.5",
                "Mac OS 8-9",
                "-",
                "X"),
            new DataTableEntry("Tasman",
                "Internet Explorer 5.1",
                "Mac OS 7.6-9",
                "1",
                "C"),
            new DataTableEntry("Tasman",
                "Internet Explorer 5.2",
                "Mac OS 8-X",
                "1",
                "C"),
            new DataTableEntry("Misc",
                "NetFront 3.1",
                "Embedded devices",
                "-",
                "C"),
            new DataTableEntry("Misc",
                "NetFront 3.4",
                "Embedded devices",
                "-",
                "A"),
            new DataTableEntry("Misc",
                "Dillo 0.8",
                "Embedded devices",
                "-",
                "X"),
            new DataTableEntry("Misc",
                "Links",
                "Text only",
                "-",
                "X"),
            new DataTableEntry("Misc",
                "Lynx",
                "Text only",
                "-",
                "X"),
            new DataTableEntry("Misc",
                "IE Mobile",
                "Windows Mobile 6",
                "-",
                "C"),
            new DataTableEntry("Misc",
                "PSP browser",
                "PSP",
                "-",
                "C"),
            new DataTableEntry("Other browsers",
                "All others",
                "-",
                "-",
                "U")
        };

        public List<DataTableEntry> Search(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return new List<DataTableEntry>();
            }
            var text = searchText.ToLower();
            return mockData.Where(e => e.RenderingEngine.ToLower().Contains(text) ||
                                       e.Browser.ToLower().Contains(text) ||
                                       e.CssGrade.ToLower().Contains(text) ||
                                       e.EngineVersion.ToLower().Contains(text) ||
                                       e.Platforms.ToLower().Contains(text)).ToList();
        }
    }
}