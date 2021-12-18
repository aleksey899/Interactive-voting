# Информационная система интерактивного голосования
***

## Содержание

[Введение](#введение) 

1 [Описание предметной области](#предметная_область)

1.1 [Актуальность задачи](#актуальность)

2 [Сравнительный анализ ](#сравнительный_анализ)

3 [Разработка системы](#разработка_системы)

3.1 [Этап проектирования](#проектирование)

3.2 [Этап реализации](#реализация)

4 [Проверка и тестирование системы](#тестирование)

[Заключение](#заключение)

[Список использованных источников](#список_использованных_источников)

***

## Введение
Необходимо разработать информационную систему "интерактивного голосования". Голсование является значимой частью политической сферы жизни общества, оно даёт возможность участвовать в процессе управления государством и непосредственно влиять на формирование органов власти. Понятие интерактивного голосования, в общем виде, определяет процедуру волеизъявления избирателей, подсчёта голосов и подведения итогов голосования. Информационная система поможет сэкономить время, а также денежные средства.

***
## 1 Описание предметной области <a name="предметная_область"></a>
***
  
 Голосование-это способ принятия решения группой людей (собранием, электоратом), при котором общее мнение формулируется путём подсчета голосов членов группы. Голосованию обычно предшествует обсуждение, поэтому в системе должны соблюдаться следующие правила: альтернатива выбора, голосование должно быть  тайным. Электронное голосование на выборах разных уровней - неизбежный шаг на пути к цифровизации нашего общества. Простыми словами, дистанционное электронное голосование это голосование через Интернет - не выходя из дома и без посещения избирательного участка.
 
 Интерактивное голосование поможет в работе с информацией о кандидатах, поэтому при описании предметной области рассматривается часть, которая каким-либо образом касается их. Работу с информационной системой осуществляют: избиратель, кандидат и администратор.
 
 Избиратель, после регистрации на платформе, узнаёт сведения о кандидатах, просматривает их агитационный материал и оставляет голос. В свою очередь кандидат также регистрируется на платформе, отправляет информацию о себе администратору и вносит агитационный материал. Проверкой голосов, одобрением на участие в выборах, записью сведений о кандидатах и информации об условиях участия в выборах занимается администратор. 
 
 ***
 ## 1.1 Актуальность задачи <a name="актуальность"></a>
 ***
 
 Актуальность исследуемой темы выражается в том,что голосование является важным фактором развития политического равенства страны и обеспечения тайного волеизъявления. Информационная система интерактивного голосования создаст условия для того, чтобы каждый избиратель, вне зависимости от своего местонахождения мог реализовать свое законное право.
 
 Информационная система является важной так как[<sup>[1]</sup>](#sourse_1):
 
 1) от участия или неучастия граждан в выборах зависит дальнейшая жизнь региона, субъекта и целой страны;
 2) Наибольшая явка избирателей на выборах является залогом честных выборов; 
 3) Экономия времени избирателей и повышение удобства избирательного процесса;
 4) Позволит снизить затраты на организацию и проведение выборов.

В демократической системе управления государством, голосование проводится при выборах должностных лиц и при принятии решений , касающихся сообщества. Благодаря интерактивному голосованию можно облегчить систему выборов в целом, а также сэкономить главный человеческий ресурс-время.
 
 ***
 ## 2 Сравнительный анализ <a name="актуальность"></a>
 ***
 
  Дистанционное электронное голосование(ДЭГ) - достаточно новая предвыборная технология в нашей стране. Одной из наиболее известных является Федеральная платформа для онлайн-голосования – программно-технического комплекса(ПТК) ДЭГ, разработанная «Ростелеком». 
  
К недостаткам ПТК ДЭК относятся[<sup>[2]</sup>](#sourse_2):

1) не все избиратели информированы о данной системе и не все имеют возможность голосовать через интернет;
2) Часть избирателей опасается, что их «электронный» голос могут подделать;
3) Страх избирателей, что их персональные данные могут «утечь» в интернет или просто быть проданы мошенникам;
4) Неудобный интерфейс.

К достоинствам ПТК ДЭК относятся:

1) повышение электоральной явки;
2) Технология блокчейн позволяющая бороться с фальсификациями разного рода;
3) Достаточно много информации об кандидатах, включая агитационные материалы.

В системе, которую нужно спроектировать будут приниматься меры по предотвращению мошенничества и утечек информации из системы, а также будет удобный и простой интерфейс 
 
 ***

 ## 3 Разработка ИС <a name="разработка_системы"></a>
 ***
 Разработка информационной системы делится на два этапа: проектирование и реализация. Проектирование является начальным уровнем разработки. На данном этапе описываются система и ее элементы, конкретные требования к системе, а также конкретные технические и программные решения. 
 На этапе реализации результаты проектирования преобразуются в готовый программный продукт. Здесь же происходит создание интерфейса и написание программного кода.
 
 
 ***
 
 ### 3.1 Проектирование ИС <a name="проектирование"></a>
 ***
Проектирование состоит из трех этапов. В этом процессе используются основные идеи системного подхода и в полной мере проявляются его преимущества.
 
Разработка начианется с проектрирования USE CASE диаграммы, отображающей основные лица данной системы: Администратор, Избиратель и Кандидат (рисунок 1).
 <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146237452-3c7c90e6-69b6-4171-a55c-ab95959f6573.PNG"></p>
<p align="center"> Рисунок 1 - USE CASE диаграмма</p>
 
После на основе  USE CASE диаграммы создаетя диаграмма DFD (Data Flow Diagrams), которая наглядно отображает течение информации в системе (рисунок 2).
 <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146239525-638f32b9-e4ed-48b3-b9a7-64d8dc21bc0e.PNG"></p>
<p align="center"> Рисунок 2 - DFD диаграмма</p>

На основе DFD диаграммы создается сущность ER-диаграммы, которая показывает связи в системе (рисунок 3).
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146240013-a19229b9-e8aa-4983-a2c9-0042e61ce6d0.PNG"></p>
<p align="center">Рисунок 3 - ER-диаграмма</p>
 
 ***
 
 ### 3.2 Реализация ИС <a name="реализация"></a>
 ***

    
Реализация системы  начинается с ER-диаграммы, создаются классы листинг 1.

```csharp 
    using Inter.MixAN.Repository;


namespace Inter.MixAN.Domain
{
    public class Admin: IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string ListOfCandidates { get; set; }

        public int CandidateInformationID { get; set; }

        public int ElectionsInformationID { get; set; }

        public int TermsParticipationID { get; set; }

        public int UserInformationID { get; set; }

        Admin(int id, string name, string email, int phoneNumber, string listOfCandidates, int candidateInformationID, int electionsInformationID, int termsParticipationID, int userInformationID)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            ListOfCandidates = listOfCandidates;
            CandidateInformationID = candidateInformationID;
            ElectionsInformationID = electionsInformationID;
            TermsParticipationID = termsParticipationID;
            UserInformationID = userInformationID;
        }
    }
}

```
<p align="center">Листинг 1 - Класс "Администратор"</p>

Далее были созданы классы для других сущностей (рисунок 4)
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146316787-722e0f26-e69c-4e46-8ec7-c4d0e350e4ef.PNG"></p>
<p align="center">Рисунок 4 - Классы других сущностей </p>


Далее для сущности Админ реализуем контроллер с методами CRUD (create, read, update, delete), листинг 2.

```csharp 
using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;
namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Admin")]
    public class AdministratorEntityController : ControllerBase
    {
        [HttpPost("Create")]
        public bool Create(Admin admin)
        {
            return Storages.AdminStorage.Create(admin);
        }

        [HttpGet("Read")]
        public Admin Read(int Id)
        {
            return Storages.AdminStorage.Read(Id);
        }

        [HttpPut("Update")]
        public Admin Update(Admin admin)
        {
            return Storages.AdminStorage.Update(admin);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.AdminStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.AdminStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.AdminStorage.ReadFromXmlFile();
        }

```
<p align="center">Листинг 2 - Класс "Администратор</p>

После реализованы контроллеры для остальных сущностей (рисунок 5)
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146317108-8ce6b032-d6dc-4b12-a99b-4aa3c53c0deb.PNG"></p>
<p align="center"> Рисунок 5 - Контроллеры других сущностей
  

- Создав репозитории, опредилим где будет хранится, листинг 3.

```csharp 
  
 public class Storages
    {
        public static Storage<Admin> AdminStorage { get; } = new();
        public static Storage<Application> ApplicationStorage { get; } = new();
        public static Storage<Candidate> CandidateStorage { get; } = new();
        public static Storage<InformationCandidate> InformationCandidateStorage { get; } = new();
        public static Storage<InformationVoter> InformationVoterStorage { get; } = new();
        public static Storage<MaterialsForAgitation> MaterialsForAgitationStorage { get; } = new();
        public static Storage<TermsOfParticipation> TermsOfParticipationStorage { get; } = new();
        public static Storage<Voter> VoterStorage { get; } = new();
    }

```
 <p align="center">Листинг 3 - Общее хранилище
  

  
 ***
 
 ## 4 Проверка и тестирование системы <a name="тестирование"></a>
 ***
В качестве тестирования информационной системы была выполнена проверка работы контроллеров в Swagger UI (рисунок 6). 
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146330300-184e40ac-2812-4513-9c41-9c59bc2d4325.PNG"></p>
<p align="center">Рисунок 6 - Проверка контроллеров в Swagger UI </p>
 
Работа основных методов CRUD на примере сущности Administrator.
  
  1) С помощью операции Create можно создавать новые записи в таблице (рисунок 7).
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146640305-17f8c47a-ba22-434f-9172-312cc0414a79.PNG"></p>
<p align="center">Рисунок 7 - Реализация операции Create </p>
  
  Создание записи о Администраторе (рисунок 8).
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146640845-7feab474-815a-4fa2-a50c-b8ba44876b19.PNG"></p>
<p align="center">Рисунок 8 - Создание новой записи </p>
  
  В ходе выполнения операции получаем результат (рисунок 9).
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146640862-34b44777-de01-4648-95ba-90b8b93d7b24.PNG"></p>
<p align="center">Рисунок 9 - Результат операции Create </p>
  
  2) Метод Read позволяет считать значение записи, выбранной по определенному критерию (рисунок 10).
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146641866-971e137b-79ed-4395-bda4-f046f2caa6ca.PNG"></p>
<p align="center">Рисунок 10 - Реализация операции Read </p>
  
  Реализация чтения информации об Администраторе с ID=14890 (рисунок 11).
   <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146642910-c4a160a1-5b08-47c8-bdf8-121dec95cb31.PNG"></p>
<p align="center">Рисунок 11 - Чтение записи и результат </p>
   
 3) Операция Update позволяет изменить запись (рисунок 12).
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146643329-bd4e8c7e-ab1a-45c0-9de6-9e144b298fce.PNG"></p>
<p align="center">Рисунок 12 - Реализация операции Update </p>  
  
  Изменение почты администратора и результат операции (рисунок 13).
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146643411-c980301a-b034-438e-950c-784d291c03d6.PNG"></p>
<p align="center">Рисунок 13 - Редактирование записи и результат операции Update </p> 
  
  4) Метод Delete удаляет записи. В случае успешного удаления выводится true, иначе - false (рисунок 14). 
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146643527-d2a37a1b-e8cd-4a14-b8c5-0b6d48682d89.PNG"></p>
<p align="center">Рисунок 14 - Реализация метода Delete</p>
  
  Удаление записи об администраторе (рисунок 15).
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146643626-f785097e-91d9-4631-b17d-4c4644b8d431.PNG"></p>
<p align="center">Рисунок 15 - Удаление записи</p>
  
  Результат операции Delete (рисунок 16)
   <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146643729-fdc2feb2-311a-4178-b207-e62491adb4b8.PNG"></p>
<p align="center">Рисунок 16 - Результат операции</p>

  
  
  
***
 ## Заключение <a name="заключение"></a>
***

В результате проделанной работы были достигнуты поставленные цели и задачи проекта. Была разработана информационная система интерактивного голосования. В процессе проектирования удалось реализовать и протестировать информационную систему "Интерактивное голосование". Данная информационная система выполняет функции создания, чтения, редактирования и удаления записей. 
 
 ## Список использованных источников <a name="список_использованных_источников"></a>
  
 <a name="sourse_1"> 
[1] Независимый общественный мониторинг [Электронный ресурс]. - https://nom24.ru/info/events/pochemu-vazhno-i-nuzhno-khodit-na-vybory/ (дата доступа: 07.11.2021)
    
 <a name="sourse_2">     
[2] Информационный портал о выборах "Выбор народа" [Электронный ресурс]. – http://vybor-naroda.org/lentanovostey/193789-na-puti-k-cifrovizacii-pljusy-i-minusy-djeg.html (дата доступа: 07.11.2021)
  
  
[2] Draw.io [Электронный ресурс]. – https://app.diagrams.net/
  
  
 
  
  
  
 
