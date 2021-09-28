using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartRestartWebApp.Pages
{
    public class IndexModel : PageModel
    {

       private readonly IApplicationLifetime _applicationShutdown;

        private readonly IWritableOptions<AzureAdOptions> _options;

        private readonly IWritableOptions<SMTPSettingOptions> _smtpoptions;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IApplicationLifetime applicationShutdown, IWritableOptions<AzureAdOptions> options, IWritableOptions<SMTPSettingOptions> smtpoptions)
        {
            _logger = logger;
            _applicationShutdown = applicationShutdown;
            _options = options;
            _smtpoptions = smtpoptions;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {

            var oldid = _options.Value.ClientId;

            var oldcallbackpath = _options.Value.ClientId;

            _options.Update(opt => {
                opt.CallbackPath = "fdsfdgfdgfd";
                opt.ClientId = "valugfdgfdgdfgfde2";
            });

           var newid= _options.Value.ClientId;

           var newcallbackpath = _options.Value.ClientId;



            _smtpoptions.Update(opt =>
            {
                opt.AbpMailingDefaultFromAddress = "sfsddsfdfggfdgf";
                opt.AbpMailingSmtpPort = "gfdgfdgfd";
            });



            _applicationShutdown.StopApplication();
            

            return Page();
        }
    }
}
