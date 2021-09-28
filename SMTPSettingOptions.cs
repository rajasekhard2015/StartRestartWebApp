using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartRestartWebApp
{
    public class SMTPSettingOptions
    {
        [JsonProperty("Volo.Abp.LeptonTheme.Style")]
        public string VoloAbpLeptonThemeStyle { get; set; }

        [JsonProperty("Volo.Abp.LeptonTheme.Layout.MenuPlacement")]
        public string VoloAbpLeptonThemeLayoutMenuPlacement { get; set; }

        [JsonProperty("Volo.Abp.LeptonTheme.Layout.MenuStatus")]
        public string VoloAbpLeptonThemeLayoutMenuStatus { get; set; }

        [JsonProperty("Volo.Abp.LeptonTheme.Layout.Boxed")]
        public string VoloAbpLeptonThemeLayoutBoxed { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.Host")]
        public string AbpMailingSmtpHost { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.Port")]
        public string AbpMailingSmtpPort { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.UserName")]
        public string AbpMailingSmtpUserName { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.Password")]
        public string AbpMailingSmtpPassword { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.Domain")]
        public string AbpMailingSmtpDomain { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.EnableSsl")]
        public string AbpMailingSmtpEnableSsl { get; set; }

        [JsonProperty("Abp.Mailing.Smtp.UseDefaultCredentials")]
        public string AbpMailingSmtpUseDefaultCredentials { get; set; }

        [JsonProperty("Abp.Mailing.DefaultFromAddress")]
        public string AbpMailingDefaultFromAddress { get; set; }

        [JsonProperty("Abp.Mailing.DefaultFromDisplayName")]
        public string AbpMailingDefaultFromDisplayName { get; set; }
    }
}
