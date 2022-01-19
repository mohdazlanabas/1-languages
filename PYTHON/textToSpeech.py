from ibm_cloud_sdk_core.authenticators import IAMAuthenticator
from ibm_watson import TextToSpeechV1
url = 'https://api.au-syd.text-to-speech.watson.cloud.ibm.com/instances/e99507bf-c2a7-4531-9a91-a4b6e3c6a085'
apikey = 'lBpfB5DbqZhE2WLb0O10jLwyWiLap150FBY1MrwfAJNJ'
authenticator = IAMAuthenticator(apikey)
tts = TextToSpeechV1(authenticator=authenticator)
tts.set_service_url(url)
texts = 'Good Morning, fellow SEAPORTIANS, you all have a good day now.'
with open('./speech.mp3', 'wb') as audio_file:
    res = tts.synthesize(texts, accept='audio/mp3', voice='en-GB_JamesV3Voice').get_result()
    audio_file.write(res.content)
