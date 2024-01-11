import React from 'react';
import CardItem from '../components/CardItem';
import './Cards.css';

function Cards() {
  return (
    <div className='cards'>
      <h1>Nezd meg szines tevekenyseginket</h1>
      <div className='cards__container'>
      <div className='cards__wrapper'>
        <ul className='cards__items'>
          <CardItem 
          src="images/vr.jpg"
          text="Ha kíváncsi vagy még több érdekességre nézz szét az oldalunkon!"
          label='WeAreTheVR'
          path="/services"
         />
             <CardItem 
          src="images/AC.jpg"
          text="Ha kíváncsi vagy még több érdekességre nézz szét az oldalunkon!"
          label='Streamek'
          path="/services"
         />
              
        </ul>
        <ul className='cards__items'>
        <CardItem 
          src="images/lego.jpg"
          text="Ha kíváncsi vagy még több érdekességre nézz szét az oldalunkon!"
          label='Lego'
          path="/services"
         />
             <CardItem 
          src="images/podcast.jpg"
          text="Ha kíváncsi vagy még több érdekességre nézz szét az oldalunkon!"
          label='Podcast-ek'
          path="/services"
         />
         <CardItem 
          src="images/podcast.jpg"
          text="Ha kíváncsi vagy még több érdekességre nézz szét az oldalunkon!"
          label='Podcast-ek'
          path="/services"
         />
        </ul>
      </div>
      </div>
     
    </div>
  )
}

export default Cards