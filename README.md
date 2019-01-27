# Consignment Shops
A retail management system built by ShomarMensah


Consignment Shop App
Create an application that can be used by Consignment shops to run their business. You need to know who the individual/vendors are, who have items in the shop and you need to associate these vendors with their items. Each vendor should be assigned a standard commission but that may need to be changed on a vendor basis. The application should track how much should be paid to each vendor as well as how much money should be paid to the store.

Requirements:
1.	List of vendors
2.	List of items per vendor
3.	Each vendor should have a default commission
4.	Commission can change
5.	Track how much to pay the vendors

Vendor	Type
First Name	String
Last Name	String
Commision rate	Double
	
	
	
Item	
Title	String
Description	String
Price	Decimal
Sold	Boolean
Paymentdistribution	Boolean
Owners	Vendor
	
	
Store	
Name	String
Vendors	vendor
Items	
