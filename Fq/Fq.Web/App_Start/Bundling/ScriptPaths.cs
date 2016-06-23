﻿using System.IO;
using System.Threading;
using System.Web;
using Abp.Extensions;

namespace Fq.Web.Bundling
{
    public static class ScriptPaths
    {
        public const string Json2 = "~/libs/json2/json2.min.js";

        public const string JQuery = "~/libs/jquery/jquery.js";
        public const string JQuery_Migrate = "~/libs/jquery/jquery-migrate.min.js";
        public const string JQuery_UI = "~/libs/jquery-ui/jquery-ui.js";

        public const string JQuery_Slimscroll = "~/libs/jquery-slimscroll/jquery.slimscroll.min.js";
        public const string JQuery_BlockUi = "~/libs/jquery-blockui/jquery.blockui.min.js";
        public const string JQuery_Cookie = "~/libs/jquery-cookie/jquery.cookie.min.js";
        public const string JQuery_Uniform = "~/libs/jquery-uniform/jquery.uniform.min.js";
        public const string JQuery_Ajax_Form = "~/libs/jquery-ajax-form/jquery.form.js";
        public const string JQuery_Validation = "~/libs/jquery-validation/js/jquery.validate.min.js";
        public const string JQuery_Bootstrap_Switch = "~/libs/bootstrap-switch/js/bootstrap-switch.min.js";

        public const string Bootstrap = "~/libs/bootstrap/bootstrap.js";
        public const string Bootstrap_Hover_Dropdown = "~/libs/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js";
        public const string Bootstrap_DateRangePicker = "~/libs/bootstrap-daterangepicker/daterangepicker.js";
        public const string Bootstrap_DateTimePicker = "~/libs/bootstrap-datetimepicker/bootstrap-datetimepicker.min.js";
        public const string Bootstrap_Select = "~/libs/bootstrap-select/bootstrap-select.min.js";
        public const string Bootstrap_Switch = "~/libs/bootstrap-switch/js/bootstrap-switch.min.js";

        public const string SignalR = "~/libs//signalr/jquery.signalR.js";

        public const string JsTree = "~/libs/jstree/jstree.js";
        public const string SpinJs = "~/libs/spinjs/spin.js";
        public const string SpinJs_JQuery = "~/libs/spinjs/jquery.spin.js";

        public const string SweetAlert = "~/libs/sweetalert/sweet-alert.min.js";
        public const string Toastr = "~/libs/toastr/toastr.js";

        public const string MomentJs = "~/libs/moment/moment-with-locales.js";
        public const string Underscore = "~/libs/underscore/underscore.min.js";

        public const string MustacheJs = "~/libs/mustachejs/mustache.min.js";

        public const string Angular = "~/libs/angularjs/angular.js";
        public const string Angular_Sanitize = "~/libs/angularjs/angular-sanitize.js";
        public const string Angular_Ui_Bootstrap_Tpls = "~/libs/angularjs/angular-ui/ui-bootstrap-tpls.min.js";
        public const string Angular_Ui_Utils = "~/libs/angularjs/angular-ui/ui-utils.js";
        public const string Angular_Ui_Router = "~/libs/angularjs/angular-ui-router.js";
        public const string Angular_OcLazyLoad = "~/libs/angularjs/ocLazyLoad.min.js";
        public const string Angular_Moment = "~/libs/angularjs/angular-moment/angular-moment.min.js";
        public const string Angular_Ui_Grid = "~/libs/angularjs/angular-ui-grid/ui-grid.min.js";
        public const string Angular_DateRangePicker = "~/libs/angularjs/angular-daterangepicker/angular-daterangepicker.min.js";
        public const string Angular_Bootstrap_Switch = "~/libs/angularjs/angular-bootstrap-switch/angular-bootstrap-switch.min.js";
        public const string Angular_File_Upload = "~/libs/angularjs/angular-file-upload/angular-file-upload.min.js";

        public const string Abp = "~/Abp/Framework/scripts/abp.js";
        public const string Abp_JQuery = "~/Abp/Framework/scripts/libs/abp.jquery.js";
        public const string Abp_Toastr = "~/Abp/Framework/scripts/libs/abp.toastr.js";
        public const string Abp_BlockUi = "~/Abp/Framework/scripts/libs/abp.blockUI.js";
        public const string Abp_SpinJs = "~/Abp/Framework/scripts/libs/abp.spin.js";
        public const string Abp_SweetAlert = "~/Abp/Framework/scripts/libs/abp.sweet-alert.js";
        public const string Abp_Angular = "~/Abp/Framework/scripts/libs/angularjs/abp.ng.js";
        public const string Abp_jTable = "~/Abp/Framework/scripts/libs/abp.jtable.js";

        public const string UEditor = "~/libs/ueditor/ueditor.all.js";
        public const string UEditor_Cfg = "~/libs/ueditor/ueditor.config.js";
        public const string UEditor_Lang = "~/libs/ueditor/lang/zh-cn/zh-cn.js";
        public const string Angular_UEditor = "~/libs/angularjs/angular-ueditor/angular.ueditor.js";

        public static string Angular_Localization
        {
            get
            {
                return GetLocalizationFileForjAngularOrNull(Thread.CurrentThread.CurrentUICulture.Name.ToLower())
                       ?? GetLocalizationFileForjAngularOrNull(Thread.CurrentThread.CurrentUICulture.Name.Left(2).ToLower())
                       ?? "~/libs/i18n/angular-locale_zh-cn.js";
            }
        }

        private static string GetLocalizationFileForjAngularOrNull(string cultureCode)
        {
            try
            {
                var relativeFilePath = "~/libs/i18n/angular-locale_" + cultureCode + ".js";
                var physicalFilePath = HttpContext.Current.Server.MapPath(relativeFilePath);
                if (File.Exists(physicalFilePath))
                {
                    return relativeFilePath;
                }
            }
            catch { }

            return null;
        }


        public static string JQuery_Validation_Localization
        {
            get
            {
                return GetLocalizationFileForjQueryValidationOrNull(Thread.CurrentThread.CurrentUICulture.Name.ToLower().Replace("-", "_"))
                       ?? GetLocalizationFileForjQueryValidationOrNull(Thread.CurrentThread.CurrentUICulture.Name.Left(2).ToLower())
                       ?? "~/libs/jquery-validation/js/localization/_messages_empty.js";
            }
        }

        private static string GetLocalizationFileForjQueryValidationOrNull(string cultureCode)
        {
            try
            {
                var relativeFilePath = "~/libs/jquery-validation/js/localization/messages_" + cultureCode + ".min.js";
                var physicalFilePath = HttpContext.Current.Server.MapPath(relativeFilePath);
                if (File.Exists(physicalFilePath))
                {
                    return relativeFilePath;
                }
            }
            catch { }

            return null;
        }

        public static string JQuery_JTable_Localization
        {
            get
            {
                return GetLocalizationFileForJTableOrNull(Thread.CurrentThread.CurrentUICulture.Name.ToLower())
                       ?? GetLocalizationFileForJTableOrNull(Thread.CurrentThread.CurrentUICulture.Name.Left(2).ToLower())
                       ?? "~/libs/jquery-jtable/localization/_jquery.jtable.empty.js";
            }
        }

        private static string GetLocalizationFileForJTableOrNull(string cultureCode)
        {
            try
            {
                var relativeFilePath = "~/libs/jquery-jtable/localization/jquery.jtable." + cultureCode + ".js";
                var physicalFilePath = HttpContext.Current.Server.MapPath(relativeFilePath);
                if (File.Exists(physicalFilePath))
                {
                    return relativeFilePath;
                }
            }
            catch { }

            return null;
        }

        public static string Bootstrap_Select_Localization
        {
            get
            {
                return GetLocalizationFileForBootstrapSelect(Thread.CurrentThread.CurrentUICulture.Name.ToLower())
                       ?? GetLocalizationFileForBootstrapSelect(Thread.CurrentThread.CurrentUICulture.Name.Left(2).ToLower())
                       ?? "~/libs/bootstrap-select/i18n/defaults-en_US.js";
            }
        }

        private static string GetLocalizationFileForBootstrapSelect(string cultureCode)
        {
            var localizationFileList = new[]
            {
                "ar_AR",
                "bg_BG",
                "cs_CZ",
                "da_DK",
                "de_DE",
                "en_US",
                "es_CL",
                "eu",
                "fa_IR",
                "fi_FI",
                "fr_FR",
                "hu_HU",
                "id_ID",
                "it_IT",
                "ko_KR",
                "nb_NO",
                "nl_NL",
                "pl_PL",
                "pt_BR",
                "pt_PT",
                "ro_RO",
                "ru_RU",
                "sk_SK",
                "sl_SL",
                "sv_SE",
                "tr_TR",
                "ua_UA",
                "zh_CN",
                "zh_TW"
            };

            try
            {
                cultureCode = cultureCode.Replace("-", "_");

                foreach (var localizationFile in localizationFileList)
                {
                    if (localizationFile.StartsWith(cultureCode))
                    {
                        return "~/libs/bootstrap-select/i18n/defaults-" + localizationFile + ".js";
                    }
                }
            }
            catch { }

            return null;
        }
    }
}