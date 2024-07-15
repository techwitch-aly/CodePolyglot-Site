using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodePolyglot.Models.Resume;
using Microsoft.AspNetCore.Mvc;

namespace CodePolyglot.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            ResumeModel model = new ResumeModel()
            {
                Summary = "Lead Software Engineer and Technical Architect with experience leading multiple teams on different products (4 to 6 developers per team). Experienced with designing technical solutions and communicating those solutions to business stakeholders and developers. 7+ years experience with Java, C#, JavaScript, MS SQL Server, and Microsoft Azure.",
                Technologies = new List<string>
                {
                    "Team Leadership",
                    "Site Reliability Engineering",
                    "SDLC Consulting",
                    "C#",
                    "Java / Spring",
                    "JavaScript / jQuery",
                    "SQL",
                    "CSS / Sass",
                    "Azure DevOps",
                    "Requirements Gathering",
                    "Technical Design",
                    "JIRA / Confluence"
                },
                Schools = new List<Education>()
                {
                    new Education
                    {
                        Degree = "Master of Science",
                        Field = "Computer Science",
                        SchoolName = "DePaul University",
                        SchoolCity = "Chicago, IL",
                        GradePointAverage = "3.95",
                        ExtraDetail = "Concentration: Software Engineering"
                    },
                    new Education
                    {
                        Degree = "Bachelor of Science",
                        Field = "Computer Science",
                        SchoolName = "University of Saint Francis",
                        SchoolCity = "Joliet, IL",
                        GradePointAverage = "4.0",
                        ExtraDetail = "Minor: Mathematics"
                    }
                },
                Experiences = new List<Experience>()
                {
                    new Experience
                    {
                        CompanyName = "BDO USA",
                        StartDate = new DateTime(2022, 8, 1),
                        Title = "Senior Manager, DevOps & SRE",
                        Details = new List<string>
                        {
                            "Leading the DevOps and SRE Practice",
                            "Responsible for Go-To-Market activities related to offerings and client satisfaction",
                            "Team leader for DevOps and Site Reliability Engineers and Architects"
                        }
                    },
                    new Experience
                    {
                        CompanyName = "BDO USA",
                        StartDate = new DateTime(2020, 1, 18),
                        EndDate = new DateTime(2022, 8, 1),
                        Title = "Solution Architect - Apps Group",
                        Details = new List<string>
                        {
                            "DevOps Go-To-Market leader and strategist",
                            "Responsible for overall project technical architecture and standards",
                            "Facilitate discovery sessions with clients with Functional Lead to create unified design documents"
                        }
                    },
                    new Experience
                    {
                        CompanyName = "SWC Technology Partners, LLC",
                        StartDate = new DateTime(2019, 5, 18),
                        EndDate = new DateTime(2020, 1, 18),
                        Title = "Manager, Application Development",
                        Details = new List<string>
                        {
                            "Lead on DevOps process adoption and tool selection",
                            "Continued ownership of C# and Java frameworks including security enhancements",
                            "Responsible for overall technical design for solutions, creating application architecture documentation"
                        }
                    },
                    new Experience
                    {
                        CompanyName = "SWC Technology Partners, LLC",
                        StartDate = new DateTime(2016, 6, 18),
                        EndDate = new DateTime(2019, 5, 18),
                        Title = "Senior Consultant",
                        Details = new List<string>
                        {
                            "Led multiple teams of developers across multiple simultaneous projects",
                            "Responsible for technical design of solution components",
                            "Product owner of internal Java framework, upgraded framework to support Spring Framework",
                            "Technical lead for internal C# framework"
                        }
                    },
                    new Experience
                    {
                        CompanyName = "SWC Technology Partners, LLC",
                        StartDate = new DateTime(2014, 6, 18),
                        EndDate = new DateTime(2016, 6, 18),
                        Title = "Staff Consultant",
                    },
                    new Experience
                    {
                        CompanyName = "SWC Technology Partners, LLC",
                        StartDate = new DateTime(2013, 5, 18),
                        EndDate = new DateTime(2014, 6, 18),
                        Title = "Associate Consultant",
                    },
                    new Experience
                    {
                        CompanyName = "NueMeta, LLC",
                        StartDate = new DateTime(2012, 5, 18),
                        EndDate = new DateTime(2012, 8, 18),
                        Title = "Software Engineering Intern",
                    },
                    new Experience
                    {
                        CompanyName = "University of Saint Francis",
                        StartDate = new DateTime(2008, 8, 18),
                        EndDate = new DateTime(2010, 12, 18),
                        Title = "Teaching/Lab Assistant - Computer Science",
                    }
                }
            };

            return View(model);
        }
    }
}