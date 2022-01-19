from opencage.geocoder import OpenCageGeocode
import phonenumbers
import folium
from phonenumbers import geocoder
from phonenumbers import carrier
from myNumbers import number

Key = '03f69523772c4e30ba8c932670c925da'
sanNumber = phonenumbers.parse(number)
yourLocation = geocoder.description_for_number(sanNumber, "en")
print(yourLocation)

# get service provider
service_provider = phonenumbers.parse(number)
print(carrier.name_for_number(service_provider, "en"))

geocoder = OpenCageGeocode(Key)
query = str(yourLocation)
results = geocoder.geocode(query)

# print(results)
lat = results[0]['geometry']['lat']
lng = results[0]['geometry']['lng']
print(lat, lng)
myMap = folium.Map(location=[lat, lng], zon_start_=9)
folium.Marker([lat, lng], popup=yourLocation).add_to(myMap)

# save map in html file
myMap.save('myLocation.html')
