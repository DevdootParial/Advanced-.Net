using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonEntity person = new PersonEntity()
            {
                PersonName = "Devdoot Parial",
                PersonEmail = "devdootparial.ai@gmail.com",
                PersonPhoneNumber = "01883569575",
                PersonDegree = "BSc",
                PersonExpertise = "Java, Pytho, C#, .Net, C++, JavaScript, PHP, HTML"
            };

            ViewBag.Person = new PersonEntity[] {person};

            return View();
        }

        public ActionResult Education()
        {
            EducationEntity e1 = new EducationEntity()
            {
                EducationName = "HSC",
                EducationYear = 2020,
                EducationGroup = "Science",
                EducationInstitute = "BAF Shaheen College Chittagong"
            };
            EducationEntity e2 = new EducationEntity()
            {
                EducationName = "SSC",
                EducationYear = 2018,
                EducationGroup = "Science",
                EducationInstitute = "Chittagong Labarotory School And College"
            };

            ViewBag.Education = new EducationEntity[] {e1, e2};

            return View();
        }

        public ActionResult Projects()
        {
            ProjectsEntity p1 = new ProjectsEntity()
            {
                ProjectTitle = "Book Store Management System",
                ProjectDesc = "A simple command line Book Store Management System",
                ProjectCourse = "OOP1 (Java)"
            };
            ProjectsEntity p2 = new ProjectsEntity()
            {
                ProjectTitle = "Library Management System",
                ProjectDesc = "A GUI-based library management system",
                ProjectCourse = "OOP2 (C#)"
            };
            ProjectsEntity p3 = new ProjectsEntity()
            {
                ProjectTitle = "Book Shop Management System",
                ProjectDesc = "A HTML, CSS, PHP based Web Project for Book Shop  Management system",
                ProjectCourse = "Webtech"
            };
            ProjectsEntity p4 = new ProjectsEntity()
            {
                ProjectTitle = "Natural_Mountain_Scenario ",
                ProjectDesc = "A Natural_Mountain_Scenario Project for Computer Graphics",
                ProjectCourse = "Computer Graphics"
            };

            ViewBag.Projects = new ProjectsEntity[] {p1, p2, p3, p4};

            return View();
        }

        public ActionResult Certifications()
        {


            return View();
        }
        public ActionResult References()
        {
            ViewBag.Reference1 = "Hasibul Hasan";
            ViewBag.Reference2 = "MD. AL-AMIN";

            return View();
        }
        public ActionResult ReferenceDetails(string refName)
        {
            ViewBag.RefName = refName;

            return View();
        }



    }
}