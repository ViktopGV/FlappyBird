var jsplugin = {
    IsMobile: function()
     {
         return Module.SystemInfo.mobile;
     }
};

mergeInto(LibraryManager.library, jsplugin);