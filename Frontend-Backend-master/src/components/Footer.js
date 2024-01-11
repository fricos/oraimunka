import React from 'react'
import {Button} from './Button'
import {Link} from 'react-router-dom'
import './Footer.css';
function Footer() {
  return (
    <div className='footer-container'>
        <section className='footer-subscription'>
            <p className='footer-subscription-heading'>
                Csatlakozz hozzánk, hogy Te is részese lehetsz ezekneg a nagyszerű élményeknek.
            </p>
            <p className='footer-subscription-text'>
                Ne maradj le a legujabb programokról!
            </p>
            <div className='input-areas'>
                <form>
                    <input type='email' name='email' placeholder='E-mail címed...' className='footer-input'/>
                    <Button buttonStyle='btn--outline'>Megosztás</Button>

                   
                </form>

            </div>
        </section>
        <div className='footer-links'>
            <div className='footer-link-wrapper'>
                <div className='footer-link-items'>
                    <h2>Rólunk</h2>
                    <Link to="/sign-up">Hogyan működik</Link>
                    <Link to="/">Vissza a főoldalra</Link>
                    <Link to="/">Karrier</Link>
                    <Link to="/">Események</Link>
                    <Link to="/">Szolgáltatásaink</Link>
                    <Link to="/">Webshopunk</Link>
                </div>
                <div className='footer-link-items'>
                    <h2>Rólunk</h2>
                    <Link to="/sign-up">Hogyan működik</Link>
                    <Link to="/">Vissza a főoldalra</Link>
                    <Link to="/">Karrier</Link>
                    <Link to="/">Események</Link>
                    <Link to="/">Szolgáltatásaink</Link>
                    <Link to="/">Webshopunk</Link>
                </div>
                
                
        </div>
        <div className='footer-link-wrapper'>
                <div className='footer-link-items'>
                    <h2>Rólunk</h2>
                    <Link to="/sign-up">Hogyan működik</Link>
                    <Link to="/">Vissza a főoldalra</Link>
                    <Link to="/">Karrier</Link>
                    <Link to="/">Események</Link>
                    <Link to="/">Szolgáltatásaink</Link>
                    <Link to="/">Webshopunk</Link>
                </div>
                <div className='footer-link-items'>
                    <h2>Rólunk</h2>
                    <Link to="/sign-up">Hogyan működik</Link>
                    <Link to="/">Vissza a főoldalra</Link>
                    <Link to="/">Karrier</Link>
                    <Link to="/">Események</Link>
                    <Link to="/">Szolgáltatásaink</Link>
                    <Link to="/">Webshopunk</Link>
                </div>
            </div>
            </div>
            <section className="social-media">
                <div className='social-media-wrap'>
                    <div className='footer-logo'>
                        <Link to='/' className='social-logo'>
                            TheVr <i class="fa-solid fa-dice-d20"></i>
                        </Link>
                    </div>
                    <small className='website-rights'>TheVr 2023</small>
                    <div className='social-icons'>
                        <Link className='social-icon-link facebook'
                        to="/"
                        target='_blank'
                        ariel-label='Facebook'>
                            <i class="fa-brands fa-square-facebook"></i>
                        </Link>
                        <Link className='social-icon-link instagram'
                        to="/"
                        target='_blank'
                        ariel-label='Instagram'>
                         <i class="fa-brands fa-square-instagram"></i>
                        </Link>
                        <Link className='social-icon-link twitter'
                        to="/"
                        target='_blank'
                        ariel-label='Twitter'>
                        <i class="fa-brands fa-square-twitter"></i>
                        </Link>
                        <Link className='social-icon-link linkedin'
                        to="/"
                        target='_blank'
                        ariel-label='Linkedin'>
                       <i class="fa-brands fa-linkedin"></i>
                        </Link>
                    </div>
                </div>

            </section>
    </div>
  )
}

export default Footer