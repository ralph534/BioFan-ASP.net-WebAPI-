using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using BioFan.Models;
using Microsoft.AspNetCore.Hosting;


namespace BioFan.Services
{
	public class AthleteService
	{
        public AthleteService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        } 

        public IWebHostEnvironment WebHostEnvironment { get; }


        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "athletes.json"); }
        }


        public IEnumerable<Athlete> GetAthletes()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Athlete[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}

