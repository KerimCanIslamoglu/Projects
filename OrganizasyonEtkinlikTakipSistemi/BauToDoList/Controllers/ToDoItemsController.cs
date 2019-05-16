using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BauToDoList.Models;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.IO;

namespace BauToDoList.Controllers
{
    public class ToDoItemsController : Controller
    {
        private appDbContext db = new appDbContext();

        // GET: ToDoItems
        public async Task<ActionResult> Index()
        {
            var toDoItems = db.ToDoItems.Include(t => t.Category).Include(t => t.Customer).Include(t => t.Department).Include(t => t.Manager).Include(t => t.Organizator).Include(t => t.Side);
            return View(await toDoItems.ToListAsync());
        }

        // GET: ToDoItems/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoItem toDoItem = await db.ToDoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return HttpNotFound();
            }
            return View(toDoItem);
        }

        // GET: ToDoItems/Create
        public ActionResult Create()
        {
            var toDoItem = new ToDoItem();

            toDoItem.MeetingDate = DateTime.Now;
            toDoItem.MeetingHour = DateTime.Now;
            toDoItem.FinishDate = DateTime.Now;
            toDoItem.FinishHour = DateTime.Now;
            toDoItem.PlannedDate = DateTime.Now;
            toDoItem.PlannedHour = DateTime.Now;
            toDoItem.ReviseDate = DateTime.Now;
            toDoItem.ScheduledOrganizationDate = DateTime.Now;
            toDoItem.ReviseHour = DateTime.Now;
            toDoItem.ScheduledOrganizationHour = DateTime.Now;

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "Name");
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name");
            ViewBag.ManagerId = new SelectList(db.Contacts, "Id", "FirstName");
            ViewBag.OrganizatorId = new SelectList(db.Contacts, "Id", "FirstName");
            ViewBag.SideId = new SelectList(db.Sides, "Id", "Name");

            return View(toDoItem);
        }

        // POST: ToDoItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Title,Description,Status,CategoryId,Attachment,DepartmentId,SideId,CustomerId,ManagerId,OrganizatorId,MeetingDate,PlannedDate,FinishDate,ReviseDate,ConversationSubject,SupporterCompany,SupporterDoctor,ConversationAttendeeCount,ScheduledOrganizationDate,MailingSubjects,PosterSubject,PosterCount,Elearning,TypesOfScans,AsoCountInScans,TypesOfOrganization,AsoCountInOrganization,TypesOfVaccinationOrganization,AsoCountInVaccinationOrganization,AmountOfCompensantionForPoster,CorporateProductivityReport,CreatedBy,CreateDate,UpdatedBy,UpdateDate,MeetingHour,PlannedHour,FinishHour,ReviseHour,ScheduledOrganizationHour")] ToDoItem toDoItem)
        {
            if (ModelState.IsValid)
            {
                toDoItem.CreateDate = DateTime.Now;
                toDoItem.CreatedBy = User.Identity.Name;
                toDoItem.UpdateDate = DateTime.Now;
                toDoItem.UpdatedBy = User.Identity.Name;

                db.ToDoItems.Add(toDoItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", toDoItem.CategoryId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "Name", toDoItem.CustomerId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", toDoItem.DepartmentId);
            ViewBag.ManagerId = new SelectList(db.Contacts, "Id", "FirstName", toDoItem.ManagerId);
            ViewBag.OrganizatorId = new SelectList(db.Contacts, "Id", "FirstName", toDoItem.OrganizatorId);
            ViewBag.SideId = new SelectList(db.Sides, "Id", "Name", toDoItem.SideId);
            return View(toDoItem);
        }

        // GET: ToDoItems/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoItem toDoItem = await db.ToDoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", toDoItem.CategoryId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "Name", toDoItem.CustomerId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", toDoItem.DepartmentId);
            ViewBag.ManagerId = new SelectList(db.Contacts, "Id", "FirstName", toDoItem.ManagerId);
            ViewBag.OrganizatorId = new SelectList(db.Contacts, "Id", "FirstName", toDoItem.OrganizatorId);
            ViewBag.SideId = new SelectList(db.Sides, "Id", "Name", toDoItem.SideId);
            return View(toDoItem);
        }

        // POST: ToDoItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Title,Description,Status,CategoryId,Attachment,DepartmentId,SideId,CustomerId,ManagerId,OrganizatorId,MeetingDate,PlannedDate,FinishDate,ReviseDate,ConversationSubject,SupporterCompany,SupporterDoctor,ConversationAttendeeCount,ScheduledOrganizationDate,MailingSubjects,PosterSubject,PosterCount,Elearning,TypesOfScans,AsoCountInScans,TypesOfOrganization,AsoCountInOrganization,TypesOfVaccinationOrganization,AsoCountInVaccinationOrganization,AmountOfCompensantionForPoster,CorporateProductivityReport,CreatedBy,CreateDate,UpdatedBy,UpdateDate,MeetingHour,PlannedHour,FinishHour,ReviseHour,ScheduledOrganizationHour")] ToDoItem toDoItem)
        {
            if (ModelState.IsValid)
            {
                toDoItem.UpdateDate = DateTime.Now;
                toDoItem.UpdatedBy = User.Identity.Name;

                db.Entry(toDoItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", toDoItem.CategoryId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "Name", toDoItem.CustomerId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", toDoItem.DepartmentId);
            ViewBag.ManagerId = new SelectList(db.Contacts, "Id", "FirstName", toDoItem.ManagerId);
            ViewBag.OrganizatorId = new SelectList(db.Contacts, "Id", "FirstName", toDoItem.OrganizatorId);
            ViewBag.SideId = new SelectList(db.Sides, "Id", "Name", toDoItem.SideId);
            return View(toDoItem);
        }

        // GET: ToDoItems/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoItem toDoItem = await db.ToDoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return HttpNotFound();
            }
            return View(toDoItem);
        }

        // POST: ToDoItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ToDoItem toDoItem = await db.ToDoItems.FindAsync(id);
            db.ToDoItems.Remove(toDoItem);
            await db.SaveChangesAsync();
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
        public void ExportToExcel()
        {
            var grid = new GridView();
            grid.DataSource = from data in db.ToDoItems.ToList()
                              select new
                              {
                                  Baslik = data.Title,
                                  Aciklama = data.Description,
                                  Durum = data.Status,
                                  Kategori = data.Category,
                                  DosyaEki = data.Attachment,
                                  Departman = data.Department,
                                  Taraf = data.Side,
                                  Musteri = data.Customer,
                                  Yonetici = data.Manager,
                                  OrganizatorAdi = data.Organizator,
                                  ToplantiTarihi = data.MeetingDate.ToShortDateString(),
                                  ToplantiSaati = data.MeetingHour.ToShortTimeString(),
                                  PlanlananTarih = data.PlannedDate.ToShortDateString(),
                                  PlanlananSaat = data.PlannedHour.ToShortTimeString(),
                                  BitisTarihi = data.FinishDate.ToShortDateString(),
                                  BitisSaati = data.FinishHour.ToShortTimeString(),
                                  RevizeTarihi = data.ReviseDate.ToShortDateString(),
                                  RevizeSaati = data.ReviseHour.ToShortTimeString(),
                                  GorusmeKonusu = data.ConversationSubject,
                                  SponsorFirma = data.SupporterCompany,
                                  DestekleyenDoktor = data.SupporterDoctor,
                                  GorusmeKatilimciSayisi = data.ConversationAttendeeCount,
                                  PlanlananOrganizasyonTarihi = data.ScheduledOrganizationDate.ToShortDateString(),
                                  PlanlananOrganizasyonSaati = data.ScheduledOrganizationHour.ToShortTimeString(),
                                  MailKonulari = data.MailingSubjects,
                                  PosterKonulari = data.PosterSubject,
                                  PosterSayisi = data.PosterCount,
                                  UzaktanEgitim = data.Elearning,
                                  TaramaTurleri = data.TypesOfScans,
                                  YapilanTaramalardakiAsoSayisi = data.AsoCountInScans,
                                  OrganizasyonTurleri = data.TypesOfOrganization,
                                  OrganizasyondakiAsoSayisi = data.AsoCountInOrganization,
                                  AsiOrganizasyonuTurleri = data.TypesOfVaccinationOrganization,
                                  AsıOrganizasyonundakiAsoSayisi = data.AsoCountInVaccinationOrganization,
                                  AfisicinButceMiktari = data.AmountOfCompensantionForPoster,
                                  KurumsalVerimlilikRaporu = data.CorporateProductivityReport,
                                  OlusturmaTarihi = data.CreateDate,
                                  OlusturanKullanici = data.CreatedBy,
                                  GuncellemeTarihi = data.UpdateDate,
                                  GuncelleyenKullanici = data.UpdatedBy
                              };
            grid.DataBind();
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment;filename=ToDoItem.xls");
            Response.ContentType = "application/ms-excel";
            Response.ContentEncoding = System.Text.Encoding.Unicode;
            Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            grid.RenderControl(hw);
            Response.Write(sw.ToString());
            Response.End();
        }
        public void ExportToCSV()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("Baslik,Aciklama,Durum,Kategori,Dosya Eki,Departman,Taraf,Müşteri,Yönetici,Organizator Adı,Toplantı Tarihi,Toplantı Saati,Planlanan Tarih,Planlanan Saat,Bitiş Tarihi,Bitiş Saati,Revize Tarihi,Revize Saati,Görüşme Konusu,Sponsor Firma,Destekleyen Doktor,Görüşme Katılımcı Sayısı,Planlanan Organizasyon Tarihi,Planlanan Organizasyon Saati,Mail Konuları,Poster Konuları,Poster Sayısı,Uzaktan Eğitim,Yapılan Tarama Türleri,Yapılan Taramalardaki ASO Sayısı,Organizasyon Türleri,Organizasyonlardaki ASO Sayısı,Aşı Organizasyonu Türleri,Aşı Organizasyonundaki ASO Sayısı,Afiş İçin Bütçe Miktarı,Kurumsal Verimlilik Raporu,Oluşturulma Tarihi,Oluşturan Kullanıcı,Güncelleme Tarihi,Güncelleyen Kullanıcı");
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=ToDoItem.csv");
            Response.ContentType = "text/csv";
            Response.ContentEncoding = System.Text.Encoding.Unicode;
            Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());
            var todoitems = db.ToDoItems.ToList();
            foreach (var todoitem in todoitems)
            {
                sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39}",
                    todoitem.Title,
                    todoitem.Description,
                    todoitem.Status,
                    todoitem.Category.Name,
                    todoitem.Attachment,
                    todoitem.Department.Name,
                    todoitem.Side.Name,
                    todoitem.Customer.Name,
                    todoitem.Manager.FirstName,
                    todoitem.Organizator.FirstName,
                    todoitem.MeetingDate.ToShortDateString(),
                    todoitem.MeetingHour.ToShortTimeString(),
                    todoitem.PlannedDate.ToShortDateString(),
                    todoitem.PlannedHour.ToShortTimeString(),
                    todoitem.FinishDate.ToShortDateString(),
                    todoitem.FinishHour.ToShortTimeString(),
                    todoitem.ReviseDate.ToShortDateString(),
                    todoitem.ReviseHour.ToShortTimeString(),
                    todoitem.ConversationSubject,
                    todoitem.SupporterCompany,
                    todoitem.SupporterDoctor,
                    todoitem.ConversationAttendeeCount,
                    todoitem.ScheduledOrganizationDate.ToShortDateString(),
                    todoitem.ScheduledOrganizationHour.ToShortTimeString(),
                    todoitem.MailingSubjects,
                    todoitem.PosterSubject,
                    todoitem.PosterCount,
                    todoitem.Elearning,
                    todoitem.TypesOfScans,
                    todoitem.AsoCountInScans,
                    todoitem.TypesOfOrganization,
                    todoitem.AsoCountInOrganization,
                    todoitem.TypesOfVaccinationOrganization,
                    todoitem.AsoCountInVaccinationOrganization,
                    todoitem.AmountOfCompensantionForPoster,
                    todoitem.CorporateProductivityReport,
                    todoitem.CreateDate,
                    todoitem.CreatedBy,
                    todoitem.UpdateDate,
                    todoitem.UpdatedBy
                    ));
            }
            Response.Write(sw.ToString());
            Response.End();
        }
    }
}
