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
 
 Информационная система является важной так как:
 1 ) от участия или неучастия граждан в выборах зависит дальнейшая жизнь региона, субъекта и целой страны;
 2 ) Наибольшая явка избирателей на выборах является залогом честных выборов;
 3 ) Экономия времени избирателей и повышение удобства избирательного процесса;
 4 ) Позволит снизить затраты на организацию и проведение выборов.

В демократической системе управления государством, голосование проводится при выборах должностных лиц и при принятии решений , касающихся сообщества. Благодаря интерактивному голосованию можно облегчить систему выборов в целом, а также сэкономить главный человеческий ресурс-время.
 
 ***
 ## 2 Сравнительный анализ <a name="актуальность"></a>
 ***
 
  Дистанционное электронное голосование(ДЭГ) - достаточно новая предвыборная технология в нашей стране. Одной из наиболее известных является Федеральная платформа для онлайн-голосования – программно-технического комплекса(ПТК) ДЭГ, разработанная «Ростелеком». 
  
К недостаткам ПТК ДЭК относятся:
1) Не все избиратели информированы о данной системе и не все имеют возможность голосовать через интернет;
2) Часть избирателей опасается, что их «электронный» голос могут подделать;
3) Страх избирателей, что их персональные данные могут «утечь» в интернет или просто быть проданы мошенникам;
4) Неудобный интерфейс

К достоинствам ПТК ДЭК относятся:
1) Повышение электоральной явки;
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
 
Разработка начианется с проектрирования USE CASE диаграммы, отображающей основные лица данной системы: Администратор, Избиратель и Кандидат.
 <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146237452-3c7c90e6-69b6-4171-a55c-ab95959f6573.PNG"></p>
<p align="center"> Рисунок 1 - USE CASE диаграмма</p>
 
После на основе  USE CASE диаграммы создаетя диаграмма DFD (Data Flow Diagrams), которая наглядно отображает течение информации в системе.
 <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146239525-638f32b9-e4ed-48b3-b9a7-64d8dc21bc0e.PNG"></p>
<p align="center"> Рисунок 2 - DFD диаграмма</p>

На основе DFD диаграммы создается сущность ER-диаграммы, которая показывает связи в системе.
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146240013-a19229b9-e8aa-4983-a2c9-0042e61ce6d0.PNG"></p>
<p align="center">Рисунок 3 - ER-диаграмма</p>
 
 ***
 
 ### 3.2 Реализация ИС <a name="реализация"></a>
 ***

    
- Реализация системы  начинается с ER-диаграммы создаются классы.

```csharp 
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

```
<p align="center">Листинг 1 - Класс "Администратор</p>

-Далее были созданы классы для других сущностей (рисунок 4)
<p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146316787-722e0f26-e69c-4e46-8ec7-c4d0e350e4ef.PNG"></p>
<p align="center">Рисунок 4 - классы других сущностей </p>


-Далее для сущности Админ реализуем контроллер с методами CRUD (create, read, update, delete).

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

После реализованы контроллеры для остальных сущностей(рисунок 5)
  <p align="center">
<img src="https://user-images.githubusercontent.com/80284176/146317108-8ce6b032-d6dc-4b12-a99b-4aa3c53c0deb.PNG"></p>
<p align="center"> Рисунок 5 - Контроллеры других сущностей
  

- Создав репозитории, опредилим где будет хранится.

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
 
 
 
 

***
 ## Заключение <a name="заключение"></a>
***

В результате проделанной работы были достигнуты поставленные цели и задачи проекта. В процессе проектирования удалось реализовать и протестировать информационную систему "Интерактивное голосование". Данная информационная система выполняет функции создания, чтения, редактирования и удаления записей. Проблема, поставленная в начале работы, была решена в процессе разработки информационной системы.
 
 ## Список использованных источников <a name="список_использованных_источников"></a>
 
1. Draw.io [Электронный ресурс]. – https://app.diagrams.net/
2. Информационный портал о выборах "Выбор народа" [Электронный ресурс]. – http://vybor-naroda.org/lentanovostey/193789-na-puti-k-cifrovizacii-pljusy-i-minusy-djeg.html
 
