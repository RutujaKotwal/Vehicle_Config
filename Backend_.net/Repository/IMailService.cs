
using Vehicle_Configurator.Models;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public interface IMailService
    {
        public Task SendEmailAsync( MailRequest mailrequest);
    }
}
