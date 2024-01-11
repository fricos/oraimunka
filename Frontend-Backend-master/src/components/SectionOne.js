import React from 'react';
import '../App.css';
import './HeroSection.css';


function SectionOne() {
    return (
      <div className='hero-container'>
          <video src="/video/video-2.mp4" autoPlay loop muted />
          <h1>Business elérhetőségünk:</h1>
          <p>Email: <a href='#'>TheVR@business.com</a></p>

      </div>
    )
  }
  
  export default SectionOne;