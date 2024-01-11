import React from 'react';
import CardItem from '../components/CardItem';
import './Cards.css';

function ProdSectionTwo() {
  return (
    <div className='cards'>
      <h1>Nézd meg az új Téli kollekciónk</h1>
      <div className='cards__container'>
      <div className='cards__wrapper'>
        <ul className='cards__items'>
          <CardItem 
          src="images/vrpul.jpg"
          text="Csekkold le a az új Téli vr-os pulóverket!"
          label='Pulcsik'
          path="/Products"
         />
             <CardItem 
          src="images/vrpol.jpg"
          text="Csekkold le a az új Téli vr-os pólókat!"
          label='Pólók'
          path="/Products"
         />
              
        </ul>
        <ul className='cards__items'>
        <CardItem 
          src="images/vrsap.jpg"
          text="Csekkold le a az új Téli vr-os sápkákat!"
          label='Sapkák'
          path="/Products"
         />
             <CardItem 
          src="images/vrbog.jpg"
          text="Csekkold le a az új Téli vr-os Kulacsokat, Bögréket, Táskákat ... hosszú a lista!"
          label='Egyebek'
          path="/Products"
         />
        </ul>
      </div>
      </div>
     
    </div>
  )
}

export default ProdSectionTwo;