using Magnus.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

public class AccountController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();
    public ActionResult Index()
    {
        return View(db.students.ToList());
    }





    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginViewModel login)
    {
        if (ModelState.IsValid)
        {
            db.Users.Add(login);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        return View(login);

    }

    public ActionResult Details(string id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Student student = db.students.Find(id);
        if (student == null)
        {
            return HttpNotFound();
        }
        return View(student);
    }

    // GET: Students/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Students/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "Username,FirstName,LastName,MobileNo,EmailId,Gender,BirthDate,Country,City")] Student student)
    {
        if (ModelState.IsValid)
        {
            db.students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(student);
    }

    // GET: Students/Edit/5
    public ActionResult Edit(string id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Student student = db.students.Find(id);
        if (student == null)
        {
            return HttpNotFound();
        }
        return View(student);
    }

    // POST: Students/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "Username,FirstName,LastName,MobileNo,EmailId,Gender,BirthDate,Country,City")] Student student)
    {
        if (ModelState.IsValid)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(student);
    }

    // GET: Students/Delete/5
    public ActionResult Delete(string id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Student student = db.students.Find(id);
        if (student == null)
        {
            return HttpNotFound();
        }
        return View(student);
    }

    // POST: Students/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(string id)
    {
        Student student = db.students.Find(id);
        db.students.Remove(student);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            db.Dispose();
        }
        base.Dispose(disposing);
    }
}

    
