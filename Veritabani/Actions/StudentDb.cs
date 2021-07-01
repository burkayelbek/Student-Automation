using System;
using System.Data.SqlClient;
using DAL.Actions;
using DAL.Model;
using System.Collections.Generic;
using System.Data;
using Veritabani.Model;
using Veritabani.Actions;

namespace OgrenciOtomasyon.Actions
{
    public class StudentDb
    {
        #region Connection Part

        Connection ConnectionString = Connection.getDbInstance();
        SqlConnection conn;
        SqlCommand cmd;
        #endregion


        #region Get Lecturer Login
        public bool GetLecturerLogin(string _userName, string _password)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "SELECT Username, Password, LoginType FROM Lecturer WHERE Username = @Username and Password = @Password and LoginType='" + "1" + "'";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", _userName);
                cmd.Parameters.AddWithValue("@Password", _password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        #endregion

        #region Get Student Login
        public Student GetStudentLogin(string _userName, string _password)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "SELECT * FROM Student WHERE Username = @Username and Password = @Password and LoginType='" + "0" + "'";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", _userName);
                cmd.Parameters.AddWithValue("@Password", _password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Student loginStudent = new Student()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Department = dr["Department"].ToString(),
                        LoginType = int.Parse(dr["LoginType"].ToString()),
                        Name = dr["Name"].ToString(),
                        Password = dr["Password"].ToString(),
                        StudentIdNumber = dr["StudentIdNumber"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Username = dr["Username"].ToString()
                    };
                    return loginStudent;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        /* STUDENT PART */

        #region Get All Students

        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"	SELECT *
                                    FROM Student AS S";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    studentList.Add(new Student()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Name = dr["Name"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Department = dr["Department"].ToString(),
                        StudentIdNumber = dr["StudentIdNumber"].ToString(),
                        Username = dr["Username"].ToString(),
                        Password = dr["Password"].ToString(),
                        LoginType = int.Parse(dr["LoginType"].ToString())
                    });
                }

                return studentList;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        #endregion

        #region Get Student By Id
        public Student GetStudentById(int _stdId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "SELECT * FROM Student WHERE Id=" + _stdId + "";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Student gelenOgrenci = new Student()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Name = dr["Name"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Department = dr["Department"].ToString(),
                        StudentIdNumber = dr["StudentIdNumber"].ToString(),
                        Username = dr["Username"].ToString(),
                        Password = dr["Password"].ToString(),
                        LoginType = int.Parse(dr["LoginType"].ToString()),
                    };
                    return gelenOgrenci;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Insert Student

        public Student InsertStudent(Student _std)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "INSERT INTO Student VALUES (@name,@surname,@department,@studentIdNumber,@Username,@Password,'0')";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", _std.Name);
                cmd.Parameters.AddWithValue("@surname", _std.Surname);
                cmd.Parameters.AddWithValue("@department", _std.Department);
                cmd.Parameters.AddWithValue("@studentIdNumber", _std.StudentIdNumber);
                cmd.Parameters.AddWithValue("@Username", _std.Username);
                cmd.Parameters.AddWithValue("@Password", _std.Password);
                int numberOfAddedStudents = cmd.ExecuteNonQuery();

                if (numberOfAddedStudents > 0)
                {
                    return _std;
                }
                return null;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Update Student By Id
        public void UpdateStudentById(Student _std)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"UPDATE Student 
                                 SET Name=@Name, Surname=@Surname,  Department=@Department, StudentIdNumber=@StudentIdNumber, Username=@Username, Password=@Password
                                 WHERE Id=" + _std.Id + "";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", _std.Name);
                cmd.Parameters.AddWithValue("@Surname", _std.Surname);
                cmd.Parameters.AddWithValue("@Department", _std.Department);
                cmd.Parameters.AddWithValue("@StudentIdNumber", _std.StudentIdNumber);
                cmd.Parameters.AddWithValue("@Username", _std.Username);
                cmd.Parameters.AddWithValue("@Password", _std.Password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Delete Student
        public bool DeleteStudent(int _stdId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "DELETE FROM Student WHERE Id=" + _stdId + "";
                cmd = new SqlCommand(query, conn);
                int deletedRow = cmd.ExecuteNonQuery();
                if (deletedRow > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        /* LECTURE PART */

        #region Get Al lLessons

        public List<Lesson> GetAllLessons()
        {
            List<Lesson> lessonList = new List<Lesson>();
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "SELECT Id, LessonName FROM Lesson";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    lessonList.Add(new Lesson()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        LessonName = dr["LessonName"].ToString(),
                    });
                }

                return lessonList;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region Get Lesson By Id
        public Lesson GetLessonById(int _lesId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "SELECT * FROM Lesson WHERE Id=" + _lesId + "";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Lesson gelenDers = new Lesson()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        LessonName = dr["LessonName"].ToString(),

                    };
                    return gelenDers;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Insert Lesson
        public AddLessonToStudent InsertLesson(AddLessonToStudent _lssn)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "INSERT INTO AddLessonToStudent VALUES (@LessonID,@StudentId)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LessonID", _lssn.LessonID);
                cmd.Parameters.AddWithValue("@StudentId", _lssn.StudentID);
                int numberOfAddedLessons = cmd.ExecuteNonQuery();

                if (numberOfAddedLessons > 0)
                {
                    return _lssn;
                }
                return null;

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        #endregion

        #region Update Lesson By Id

        public void UpdateLessonById(AddLessonToStudent _guncelDers)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"UPDATE AddLessonToStudent 
                                 SET LessonName=@LessonName
                                WHERE Id=" + _guncelDers.Id + "";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LessonName", _guncelDers.LessonName);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Delete Lesson

        public bool DeleteLesson(int _lessId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "DELETE FROM AddLessonToStudent WHERE Id=" + _lessId + "";
                cmd = new SqlCommand(query, conn);
                int deletedRow = cmd.ExecuteNonQuery();
                if (deletedRow > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Get All Lessons And Students
        public List<AddLessonToStudent> GetAllLessonsAndStudents()
        {
            List<AddLessonToStudent> lessonList = new List<AddLessonToStudent>();
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"SELECT AddLessonToStudent.Id, Lesson.LessonName, Student.Name, Student.Surname
                                 FROM AddLessonToStudent INNER JOIN
                                 Lesson ON AddLessonToStudent.LessonID = Lesson.Id INNER JOIN
                                 Student ON AddLessonToStudent.StudentID = Student.Id";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    lessonList.Add(new AddLessonToStudent()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        LessonName = dr["LessonName"].ToString(),
                        StudentName = dr["Name"].ToString() + " " + dr["Surname"].ToString(),
                    });
                }

                return lessonList;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        #endregion


        /* ADMIN PART */

        #region Get All Lecturer

        public List<Lecturer> GetAllLecturer()
        {
            List<Lecturer> LecturerList = new List<Lecturer>();
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"SELECT L.Id, L.Name, L.Surname, L.Username, L.Password, L.LoginType
                                 FROM Lecturer AS L";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    LecturerList.Add(new Lecturer()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Name = dr["Name"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Username = dr["Username"].ToString(),
                        Password = dr["Password"].ToString(),
                        LoginType = int.Parse(dr["LoginType"].ToString())
                    });
                }

                return LecturerList;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        #endregion

        #region Get Lecturer By Id
        public Lecturer GetLecturerById(int _LectureId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "SELECT * FROM Lecturer WHERE Id=" + _LectureId + "";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Lecturer gelenAkademisyen = new Lecturer()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Name = dr["Name"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Username = dr["Username"].ToString(),
                        Password = dr["Password"].ToString(),
                        LoginType = int.Parse(dr["LoginType"].ToString()),
                    };
                    return gelenAkademisyen;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Insert Lecturer
        public Lecturer InsertLecturer(Lecturer _lecturer)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "INSERT INTO Lecturer VALUES (@name,@surname,@username,@password,'1')";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", _lecturer.Name);
                cmd.Parameters.AddWithValue("@surname", _lecturer.Surname);
                cmd.Parameters.AddWithValue("@username", _lecturer.Username);
                cmd.Parameters.AddWithValue("@password", _lecturer.Password);
                int numberOfAddedLessons = cmd.ExecuteNonQuery();

                if (numberOfAddedLessons > 0)
                {
                    return _lecturer;
                }
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Update Lecturer By Id

        public void UpdateLecturerById(Lecturer _lecturer)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"UPDATE Lecturer SET Name=@name, Surname=@surname, Username=@username, Password=@password
                                WHERE Id=" + _lecturer.Id + "";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", _lecturer.Name);
                cmd.Parameters.AddWithValue("@surname", _lecturer.Surname);
                cmd.Parameters.AddWithValue("@username", _lecturer.Username);
                cmd.Parameters.AddWithValue("@password", _lecturer.Password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Delete Lecturer

        public bool DeleteLecturer(int _lectureId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "DELETE FROM Lecturer WHERE Id=" + _lectureId + "";
                cmd = new SqlCommand(query, conn);
                int deletedRow = cmd.ExecuteNonQuery();
                if (deletedRow > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        /* ADD EXAM RESULT PART */

        #region Add Note
        public ExamOperation AddNote(ExamOperation _examOp)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "INSERT INTO ExamOperation VALUES (@StudentId,@Exam1,@Exam2,@Homework,@LessonId)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", _examOp.StudentId);
                cmd.Parameters.AddWithValue("@Exam1", _examOp.Exam1);
                cmd.Parameters.AddWithValue("@Exam2", _examOp.Exam2);
                cmd.Parameters.AddWithValue("@Homework", _examOp.Homework);
                cmd.Parameters.AddWithValue("@LessonId", _examOp.LessonId);
                int numberOfAddedLessons = cmd.ExecuteNonQuery();

                if (numberOfAddedLessons > 0)
                {
                    return _examOp;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        #endregion

        /* ABSENTEEISM PART */
        #region Add Absenteeism
        public Absenteeism AddAbsenteeism(Absenteeism _newAbsen)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "INSERT INTO Absenteeism VALUES (@StudentId, @Date)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", _newAbsen.StudentId);
                cmd.Parameters.AddWithValue("@Date", _newAbsen.DayOfAbsenteeism);
                int numberOfAddedLessons = cmd.ExecuteNonQuery();

                if (numberOfAddedLessons > 0)
                {
                    return _newAbsen;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Get Absenteeism By StudentId
        public List<Absenteeism> GetAbsenteeismByStudentId(int studentId)
        {
            List<Absenteeism> absenteeismList = new List<Absenteeism>();
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"	SELECT *
                                    FROM Absenteeism WHERE StudentId = " + studentId;
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    absenteeismList.Add(new Absenteeism()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        DayOfAbsenteeism = (DateTime)dr["DayOfAbsenteeism"]
                    });
                }
                return absenteeismList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Toplam Get Absenteeism Total Day Number
        public string GetAbsenteeismTotalDayNumber(int studentId)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"	SELECT * 
                                    FROM Absenteeism WHERE StudentId = " + studentId;
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string totalDay = dt.Rows.Count.ToString();
                    return totalDay;
                }
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        /* EXAM OPERATION PART */

        #region Add Exam Date
        public ExaminationDate AddExamDate(ExaminationDate _exDate)
        {
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = "INSERT INTO ExaminationDate VALUES (@LessonId, @ExamDate)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LessonId", _exDate.LessonId);
                cmd.Parameters.AddWithValue("@ExamDate", _exDate.ExamDate);
                int numberOfAddedLessons = cmd.ExecuteNonQuery();

                if (numberOfAddedLessons > 0)
                {
                    return _exDate;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region GetAllExams

        public List<RepoLessonExamDate> GetAllExams()
        {
            List<RepoLessonExamDate> examList = new List<RepoLessonExamDate>();
            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"SELECT Lesson.LessonName AS [Ders], ExaminationDate.ExamDate AS [SınavTarihi] FROM Lesson 
                                  INNER JOIN ExaminationDate 
                                  ON Lesson.Id = ExaminationDate.LessonId";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    examList.Add(new RepoLessonExamDate()
                    {
                        LesName = dr["Ders"].ToString(),
                        ExDate = (DateTime)dr["SınavTarihi"]

                    });
                }

                return examList;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        #endregion

        #region Get Notes By StudentId
        public List<RepoStudentNote> GetNotesByStudentId(int _stdId)
        {
            List<RepoStudentNote> rpstdList = new List<RepoStudentNote>();

            try
            {
                conn = ConnectionString.GetDBConnection();
                string query = @"SELECT EO.Exam1, EO.Exam2, EO.Homework, Lesson.LessonName
                                 FROM AddLessonToStudent AS L INNER JOIN
                                 ExamOperation AS EO ON EO.LessonId = L.LessonID INNER JOIN
                                 Lesson ON L.LessonID = Lesson.Id
                                 WHERE EO.StudentId =" + _stdId;
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RepoStudentNote rpstd = new RepoStudentNote()
                    {
                        Exam1 = int.Parse(dr["Exam1"].ToString()),
                        Exam2 = int.Parse(dr["Exam2"].ToString()),
                        Homework = int.Parse(dr["Homework"].ToString()),
                        LessonName = dr["LessonName"].ToString()
                    };
                    rpstdList.Add(rpstd);
                }
                return rpstdList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

    }
}