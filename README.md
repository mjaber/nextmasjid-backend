# Mahareeb Project

 <img src="https://raw.githubusercontent.com/iJadou/mahareeb-brand/master/mahareeb-logo-transparency.png" alt="Mahareeb Logo">

### Introduction
Mahareeb is a **completely free non-for-profit initiative** to help people looking to build a new mosque, by providing them with information about the best places to do so, using its own smart algorithm.

Mahareeb also provides articles, content, tips and best practices on building new mosques and maintaining existing ones. 

##### The Name (Mahareeb)
(Mahareeb) is the plural for (Mihrab), an Arabic word that means a mosque or pray corner. Search for ‘Mihrab’ on Google images for examples.

### Target Audience
##### Mahareeb targets:
- Philanthropists who are looking to build mosques, and Mahareeb helps by either suggesting locations for them, or compare different locations/options for them
- Philanthropists who cannot afford to build mosques, but can search for location and ‘export’ data to share it with donators etc. 

### UI / UX

##### UI / Design Style
The website provides a simple service, that should be implemented in a simple and elegant UI. It should focus on quick actions such as “find the best location”, “compare locations” and “share it wither others.. Having responsive design is a must to accommodate different common devices.
T

##### Arabic Requirements
As the website is targeted to Arabic audience, please note the Arabic text (and design) flows from Right to Left [RTL]. 
While the main audience is Arabic speakers, and English version will be provided. Please take note. 

### Features and Content
##### Main features (in order)
1. Find the best place to build a mosque (given filters) 
	- It will look for best place to build a mosque, with a formula calculating nearest existing mosques and population in that area.
	- Locations are shown as general area, and not exact spot. A heat map can be a good example. 
	- When clicked, a pop-up will be shown to give info about location along with option to add-to-compare feature
	- Filters include: Province(s)/City(ies), Type of Mosque [Grand or regular]
2. Compare different locations
	- Clicking on any location on map will show a pop-up to show Mahareeb Score, Share, and Compare button 
3. Share Result
	- Of any location, the options to export/share should be available. The Share will enable creating a WhatsApp message with pre-written text and a link to ‘Result’ page where a map and information about the location is ready. Same thing, export will create a pdf page with same data  and a QR and link to to the result page of that location 
4. Simple Blog
	- With few posts available. Mostly:
	- You Found a Location, What to do next 
	- List of Organisation that Build Mosques
	- Best Practices
	- Government Requirements / Building Code for Mosques
	- All these articles can be in a separate blog (like wordpress with the same theme) or simply static html pages

##### Other features
1. Report an Issue or Incorrect info: to allow people to help notifying of any incorrect info (like missing existing mosques) .. This should be a link to Contact Us with ‘Report an issue’ as topic. Or a similar idea
2. Editor Pick: A page of with top 50 Locations manually selected by admin. It should be a map and result table beneath it.
3. About Mahareeb page, including information about the site and its algorithm 
4. Open Source: since the the website is open source, there should be a page about all resources including current locations and the GitHub code
5. Static content like legal, privacy policy and disclaimer, 

##### Admin Features
1. Users Login / Signup with social network accounts / google account
2. Manage Provinces / Cities / Districts and their borders on map (as done in google maps) along with information about population
3. Manage users (making users trusted, admin, inactive etc..)
4. List and approve mosques added by users 
5. List and manage mistakes and incorrect info about mosques, reported by users 
6. List and manage comments, and comments reported as inappropriate (reported by users)


##### Key Pages
Key pages to be created (incomplete list, as might need to add more or combine 2 into a page)
1. Home Page (Simple, Slider and 3 main components, ..)
2. About Us (Static, Needs creative design)
3. Contact Us (email, and a form that sends an email)
4. Article: How To’s (static pages for now, see ‘blog’ section below)
5. Search: a big map page with filters, popups, and results list
6. Result: Detailed results about location (define by lat/long) and its score and information. Easily Shareable. This page includes Lat Long Area Around it, Map ,Mahareeb Score, Information about the area (density/population count and rank), Nearest mosques and their information, Share/Export into PDF
7. Compare of Locations: 2-5 selected locations 
8. Export Feature [needs a different design for the exported content as PDF] 
9. Editors Choice: Neatly Designed best X locations as manually selected by website admin
10. Contact Us: 
11. General Inquiry 
12. Report an Issue (Missing or Wrong Info)
13. Help Pages (static)
14. Legal Pages (Terms of Use / Privacy policy etc..)
15. Blog Directory (for articles)
16. Open Data: Free Resources

##### Current Mosques  
The website has data about +80K mosques currently in Saudi Arabia. Current mosques should be presented with their information such as: Name, Type of Mosque (Grand/Normal) Year it was build (some are unknown), and a link to [incorrect info? Please notify us] or something similar. 

##### Mahareeb Score: The Algorithm  
Mahareeb.org main engine is its formula to suggest best locations. The formula is simply the combination of the following:
- Distance of existing mosques [the farther the better]
- Within city urban borders  (which should be visible in maps, and open to ‘incorrect info’ reports from website visitors) 
- Based on population density 
- City population rank (the larger the city, the more likely it will expand and needs more mosques) 

##### Login & Registration
There is no registration services needed for public. 
Login is only needed for admin, to maintain data. There should be no link to login or register, or user profile, in any page

##### Social Media & Sharing
In order to help the website to spread faster, ‘Mahareeb.org’ will utilise social media as the following:
- A Twitter account will be created, to show selected mosques and post updates (managed manually)
- A Facebook account will be created (Fan Page), to enable people to ‘like’ us and follow our latest news (managed manually) 
- Share buttons, with support for Whatsapp, Twitter, & Facebook should be available on all pages on the bottom of the page, and ALSO on each result page, to share that result as well. 

##### Blog
A simple blog should be available under blog.mahareeb.org. Only few articles will be published, all about this status of the project, and some helpful articles about mosques. (We can use simple blog engine, or static html text).




