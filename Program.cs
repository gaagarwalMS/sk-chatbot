using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.Net;

namespace ChatCompletion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load configuration
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            string endpoint = config["openai-resource:endpoint"];
            string key = config["openai-resource:key"];
        }
    }
}