using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolActivityApp.Infrastructure.Models;

namespace SchoolActivityApp.Application.Service;

public interface ICourseService
{
    IEnumerable<CourseModel> GetAllCourses();
    CourseModel GetCourseById(int id);
    void CreateCourse(CourseModel course);
    void UpdateCourse(CourseModel course);
    void DeleteCourse(int id);
}

public class CourseService : ICourseService
{
    private readonly List<CourseModel> _courses;

    public CourseService()
    {
        _courses = new List<CourseModel>(); // Simulación de base de datos
    }

    public IEnumerable<CourseModel> GetAllCourses()
    {
        return _courses;
    }

    public CourseModel GetCourseById(int id)
    {
        return _courses.FirstOrDefault(c => c.Id == id);
    }

    public void CreateCourse(CourseModel course)
    {
        // Lógica para asignar un nuevo ID, si es necesario
        if (_courses.Any())
        {
            course.Id = _courses.Max(c => c.Id) + 1;
        }
        else
        {
            course.Id = 1;
        }

        _courses.Add(course);
    }

    public void UpdateCourse(CourseModel course)
    {
        var existingCourse = GetCourseById(course.Id);
        if (existingCourse != null)
        {
            existingCourse.CursoID = course.CursoID;
            existingCourse.NombreCursoAula = course.NombreCursoAula;
            existingCourse.Capacidad = course.Capacidad;
        }
    }

    public void DeleteCourse(int id)
    {
        var course = GetCourseById(id);
        if (course != null)
        {
            _courses.Remove(course);
        }
    }
}
