import React from 'react';
import '../App.css';
import {Button} from './Button';
import './HeroSection.css';

function HeroSection() {
  return (
    <div className='hero-container'>
        <video src="/video/video-2.mp4" autoPlay loop muted />
        <h1>Mi vagyunk a TheVR</h1>
        <p>Légy részese a csapatunknak</p>
        <div className='hero-btns'>
            <Button 
             className="btns"
             buttonStyle='btn--outline'
             buttonSize='btn--large'
             >
                Kezd el
             </Button>
             <Button
             className="btns"
             buttonStyle='btn--primary'
             buttonSize='btn--large'
             >
                Trailer <i className="fa-solid fa-play" />
             </Button>
        </div>
    </div>
  )
}

export default HeroSection;