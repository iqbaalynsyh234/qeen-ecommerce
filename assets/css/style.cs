/*-----------------------------------------------------------------------------------

  Theme Name: Laevents event html 5 template
  Author: themebuzs
  Support: 
  Description: Laevents event html 5 template
  Version: 1.0

-----------------------------------------------------------------------------------

    CSS INDEX
    ===================

    1.  common
	2. header

-----------------------------------------------------------------------------------*/
/*

==================================
    1. common
==================================

*/
@import url("https://fonts.googleapis.com/css2?family=Jost:wght@400;600;700;800&family=Poppins:wght@300;400;600;700;800&display=swap");
@keyframes square {
  0% {
    transform: translateY(-100px);
    -webkit-transform: translateY(-100px);
    -moz-transform: translateY(-100px);
    -ms-transform: translateY(-100px);
    -o-transform: translateY(-100px);
  }
  100% {
    transform: translateY(0px);
    -webkit-transform: translateY(0px);
    -moz-transform: translateY(0px);
    -ms-transform: translateY(0px);
    -o-transform: translateY(0px);
  }
}
@-webkit-keyframes jump {
  0% {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
  40% {
    -webkit-transform: translate3d(0, 50%, 0);
    transform: translate3d(0, 50%, 0);
  }
  100% {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}
@keyframes jump {
  0% {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
  40% {
    -webkit-transform: translate3d(0, 50%, 0);
    transform: translate3d(0, 50%, 0);
  }
  100% {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}
@-webkit-keyframes rotated {
  0% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
  }
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}
@keyframes rotated {
  0% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
  }
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}
@-webkit-keyframes rotatedHalf {
  0% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
  }
  50% {
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
  }
  100% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
  }
}
@keyframes rotatedHalf {
  0% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
  }
  50% {
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
  }
  100% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
  }
}
@-webkit-keyframes rotatedHalfTwo {
  0% {
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
  }
  100% {
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
  }
}
@keyframes rotatedHalfTwo {
  0% {
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
  }
  100% {
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
  }
}
.float-bob {
  animation: float-bob-y infinite 3s linear;
}

@-webkit-keyframes scale-upOne {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  100% {
    -webkit-transform: scale(0.2);
    transform: scale(0.2);
  }
}
@keyframes scale-upOne {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  100% {
    -webkit-transform: scale(0.2);
    transform: scale(0.2);
  }
}
@-webkit-keyframes scale-right {
  0% {
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
  }
  50% {
    -webkit-transform: translateX(50%);
    transform: translateX(50%);
  }
  100% {
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
  }
}
@keyframes scale-right {
  0% {
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
  }
  50% {
    -webkit-transform: translateX(50%);
    transform: translateX(50%);
  }
  100% {
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
  }
}
@-webkit-keyframes fade-in {
  0% {
    opacity: 0.7;
  }
  40% {
    opacity: 1;
  }
  100% {
    opacity: 0.7;
  }
}
@keyframes fade-in {
  0% {
    opacity: 0.7;
  }
  40% {
    opacity: 1;
  }
  100% {
    opacity: 0.7;
  }
}
@keyframes hvr-ripple-out {
  0% {
    top: 0px;
    right: 0px;
    bottom: 0px;
    left: 0px;
    opacity: 1;
  }
  100% {
    top: -6px;
    right: -6px;
    bottom: -6px;
    left: -6px;
    opacity: 0;
  }
}
@keyframes hvr-ripple-out-two {
  0% {
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    opacity: 1;
  }
  100% {
    top: -12px;
    right: -12px;
    bottom: -12px;
    left: -12px;
    opacity: 0;
  }
}
@-webkit-keyframes scale-up-one {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  40% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
@keyframes scale-up-one {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  40% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
@-webkit-keyframes scale-up-two {
  0% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
  40% {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }
  100% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
}
@keyframes scale-up-two {
  0% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
  40% {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }
  100% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
}
@-webkit-keyframes scale-up-three {
  0% {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
  }
  40% {
    -webkit-transform: scale(0.4);
    transform: scale(0.4);
  }
  100% {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
  }
}
@keyframes scale-up-three {
  0% {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
  }
  40% {
    -webkit-transform: scale(0.4);
    transform: scale(0.4);
  }
  100% {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
  }
}
@-webkit-keyframes scale-up-four {
  0% {
    -webkit-transform: scale(0.6);
    transform: scale(0.6);
  }
  40% {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
  }
  100% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}
@keyframes scale-up-four {
  0% {
    -webkit-transform: scale(0.6);
    transform: scale(0.6);
  }
  40% {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
  }
  100% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}
@-webkit-keyframes scale-up-five {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  40% {
    -webkit-transform: scale(0.4);
    transform: scale(0.4);
  }
  100% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}
@keyframes scale-up-five {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  40% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
  100% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}
@keyframes animationFramesOne {
  0% {
    transform: translate(0px, 0px) rotate(0deg);
  }
  20% {
    transform: translate(73px, -1px) rotate(36deg);
  }
  40% {
    transform: translate(141px, 72px) rotate(72deg);
  }
  60% {
    transform: translate(83px, 122px) rotate(108deg);
  }
  80% {
    transform: translate(-40px, 72px) rotate(144deg);
  }
  100% {
    transform: translate(0px, 0px) rotate(0deg);
  }
}
@-webkit-keyframes animationFramesOne {
  0% {
    -webkit-transform: translate(0px, 0px) rotate(0deg);
  }
  20% {
    -webkit-transform: translate(73px, -1px) rotate(36deg);
  }
  40% {
    -webkit-transform: translate(141px, 72px) rotate(72deg);
  }
  60% {
    -webkit-transform: translate(83px, 122px) rotate(108deg);
  }
  80% {
    -webkit-transform: translate(-40px, 72px) rotate(144deg);
  }
  100% {
    -webkit-transform: translate(0px, 0px) rotate(0deg);
  }
}
@keyframes animationFramesTwo {
  0% {
    transform: translate(0px, 0px) rotate(0deg) scale(1);
  }
  20% {
    transform: translate(73px, -1px) rotate(36deg) scale(0.9);
  }
  40% {
    transform: translate(141px, 72px) rotate(72deg) scale(1);
  }
  60% {
    transform: translate(83px, 122px) rotate(108deg) scale(1.2);
  }
  80% {
    transform: translate(-40px, 72px) rotate(144deg) scale(1.1);
  }
  100% {
    transform: translate(0px, 0px) rotate(0deg) scale(1);
  }
}
@-webkit-keyframes animationFramesTwo {
  0% {
    -webkit-transform: translate(0px, 0px) rotate(0deg) scale(1);
  }
  20% {
    -webkit-transform: translate(73px, -1px) rotate(36deg) scale(0.9);
  }
  40% {
    -webkit-transform: translate(141px, 72px) rotate(72deg) scale(1);
  }
  60% {
    -webkit-transform: translate(83px, 122px) rotate(108deg) scale(1.2);
  }
  80% {
    -webkit-transform: translate(-40px, 72px) rotate(144deg) scale(1.1);
  }
  100% {
    -webkit-transform: translate(0px, 0px) rotate(0deg) scale(1);
  }
}
@keyframes animationFramesThree {
  0% {
    transform: translate(165px, -179px);
  }
  100% {
    transform: translate(-346px, 617px);
  }
}
@-webkit-keyframes animationFramesThree {
  0% {
    -webkit-transform: translate(165px, -179px);
  }
  100% {
    -webkit-transform: translate(-346px, 617px);
  }
}
@keyframes animationFramesFour {
  0% {
    transform: translate(-300px, 151px) rotate(0deg);
  }
  100% {
    transform: translate(251px, -200px) rotate(180deg);
  }
}
@-webkit-keyframes animationFramesFour {
  0% {
    -webkit-transform: translate(-300px, 151px) rotate(0deg);
  }
  100% {
    -webkit-transform: translate(251px, -200px) rotate(180deg);
  }
}
@keyframes animationFramesFive {
  0% {
    transform: translate(61px, -99px) rotate(0deg);
  }
  21% {
    transform: translate(4px, -190px) rotate(38deg);
  }
  41% {
    transform: translate(-139px, -200px) rotate(74deg);
  }
  60% {
    transform: translate(-263px, -164px) rotate(108deg);
  }
  80% {
    transform: translate(-195px, -49px) rotate(144deg);
  }
  100% {
    transform: translate(-1px, 0px) rotate(180deg);
  }
}
@-webkit-keyframes animationFramesFive {
  0% {
    -webkit-transform: translate(61px, -99px) rotate(0deg);
  }
  21% {
    -webkit-transform: translate(4px, -190px) rotate(38deg);
  }
  41% {
    -webkit-transform: translate(-139px, -200px) rotate(74deg);
  }
  60% {
    -webkit-transform: translate(-263px, -164px) rotate(108deg);
  }
  80% {
    -webkit-transform: translate(-195px, -49px) rotate(144deg);
  }
  100% {
    -webkit-transform: translate(-1px, 0px) rotate(180deg);
  }
}
@keyframes gradientBG {
  0% {
    background-position: 0 0;
  }
  50% {
    background-position: 300% 0;
  }
  100% {
    background-position: 0 0;
  }
}
@-webkit-keyframes gradientBG {
  0% {
    background-position: 0 0;
  }
  50% {
    background-position: 300% 0;
  }
  100% {
    background-position: 0 0;
  }
}
@keyframes imageBgAnim {
  0% {
    background-position: 0 0;
  }
  50% {
    background-position: 120% 0;
  }
  100% {
    background-position: 0 0;
  }
}
@-webkit-keyframes gradientBG {
  0% {
    background-position: 0 0;
  }
  50% {
    background-position: 120% 0;
  }
  100% {
    background-position: 0 0;
  }
}
:root {
  --animate-duration: 1s;
  --animate-delay: 1s;
  --animate-repeat: 1 ;
}

.animate__animated {
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-duration: var(--animate-duration);
  animation-duration: var(--animate-duration);
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
}

.animate__animated.animate__infinite {
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

.animate__animated.animate__repeat-1 {
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
  -webkit-animation-iteration-count: var(--animate-repeat);
  animation-iteration-count: var(--animate-repeat);
}

.animate__animated.animate__repeat-2 {
  -webkit-animation-iteration-count: 2;
  animation-iteration-count: 2;
  -webkit-animation-iteration-count: calc(var(--animate-repeat) * 2);
  animation-iteration-count: calc(var(--animate-repeat) * 2);
}

.animate__animated.animate__repeat-3 {
  -webkit-animation-iteration-count: 3;
  animation-iteration-count: 3;
  -webkit-animation-iteration-count: calc(var(--animate-repeat) * 3);
  animation-iteration-count: calc(var(--animate-repeat) * 3);
}

.animate__animated.animate__delay-1s {
  -webkit-animation-delay: 1s;
  animation-delay: 1s;
  -webkit-animation-delay: var(--animate-delay);
  animation-delay: var(--animate-delay);
}

.animate__animated.animate__delay-2s {
  -webkit-animation-delay: 2s;
  animation-delay: 2s;
  -webkit-animation-delay: calc(var(--animate-delay) * 2);
  animation-delay: calc(var(--animate-delay) * 2);
}

.animate__animated.animate__delay-3s {
  -webkit-animation-delay: 3s;
  animation-delay: 3s;
  -webkit-animation-delay: calc(var(--animate-delay) * 3);
  animation-delay: calc(var(--animate-delay) * 3);
}

.animate__animated.animate__delay-4s {
  -webkit-animation-delay: 4s;
  animation-delay: 4s;
  -webkit-animation-delay: calc(var(--animate-delay) * 4);
  animation-delay: calc(var(--animate-delay) * 4);
}

.animate__animated.animate__delay-5s {
  -webkit-animation-delay: 5s;
  animation-delay: 5s;
  -webkit-animation-delay: calc(var(--animate-delay) * 5);
  animation-delay: calc(var(--animate-delay) * 5);
}

.animate__animated.animate__faster {
  -webkit-animation-duration: 0.5s;
  animation-duration: 0.5s;
  -webkit-animation-duration: calc(var(--animate-duration) / 2);
  animation-duration: calc(var(--animate-duration) / 2);
}

.animate__animated.animate__fast {
  -webkit-animation-duration: 0.8s;
  animation-duration: 0.8s;
  -webkit-animation-duration: calc(var(--animate-duration) * 0.8);
  animation-duration: calc(var(--animate-duration) * 0.8);
}

.animate__animated.animate__slow {
  -webkit-animation-duration: 2s;
  animation-duration: 2s;
  -webkit-animation-duration: calc(var(--animate-duration) * 2);
  animation-duration: calc(var(--animate-duration) * 2);
}

.animate__animated.animate__slower {
  -webkit-animation-duration: 3s;
  animation-duration: 3s;
  -webkit-animation-duration: calc(var(--animate-duration) * 3);
  animation-duration: calc(var(--animate-duration) * 3);
}

@media (prefers-reduced-motion: reduce), print {
  .animate__animated {
    -webkit-animation-duration: 1ms !important;
    animation-duration: 1ms !important;
    -webkit-transition-duration: 1ms !important;
    transition-duration: 1ms !important;
    -webkit-animation-iteration-count: 1 !important;
    animation-iteration-count: 1 !important;
  }

  .animate__animated[class*=Out] {
    opacity: 0;
  }
}
@-webkit-keyframes bounce {
  0%, 20%, 53%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  40%, 43% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -30px, 0) scaleY(1.1);
    transform: translate3d(0, -30px, 0) scaleY(1.1);
  }
  70% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -15px, 0) scaleY(1.05);
    transform: translate3d(0, -15px, 0) scaleY(1.05);
  }
  80% {
    -webkit-transition-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    transition-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    -webkit-transform: translateZ(0) scaleY(0.95);
    transform: translateZ(0) scaleY(0.95);
  }
  90% {
    -webkit-transform: translate3d(0, -4px, 0) scaleY(1.02);
    transform: translate3d(0, -4px, 0) scaleY(1.02);
  }
}
@keyframes bounce {
  0%, 20%, 53%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  40%, 43% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -30px, 0) scaleY(1.1);
    transform: translate3d(0, -30px, 0) scaleY(1.1);
  }
  70% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -15px, 0) scaleY(1.05);
    transform: translate3d(0, -15px, 0) scaleY(1.05);
  }
  80% {
    -webkit-transition-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    transition-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    -webkit-transform: translateZ(0) scaleY(0.95);
    transform: translateZ(0) scaleY(0.95);
  }
  90% {
    -webkit-transform: translate3d(0, -4px, 0) scaleY(1.02);
    transform: translate3d(0, -4px, 0) scaleY(1.02);
  }
}
.animate__bounce {
  -webkit-animation-name: bounce;
  animation-name: bounce;
  -webkit-transform-origin: center bottom;
  transform-origin: center bottom;
}

@-webkit-keyframes flash {
  0%, 50%, to {
    opacity: 1;
  }
  25%, 75% {
    opacity: 0;
  }
}
@keyframes flash {
  0%, 50%, to {
    opacity: 1;
  }
  25%, 75% {
    opacity: 0;
  }
}
.animate__flash {
  -webkit-animation-name: flash;
  animation-name: flash;
}

@-webkit-keyframes pulse {
  0% {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
  50% {
    -webkit-transform: scale3d(1.05, 1.05, 1.05);
    transform: scale3d(1.05, 1.05, 1.05);
  }
  to {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
@keyframes pulse {
  0% {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
  50% {
    -webkit-transform: scale3d(1.05, 1.05, 1.05);
    transform: scale3d(1.05, 1.05, 1.05);
  }
  to {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
.animate__pulse {
  -webkit-animation-name: pulse;
  animation-name: pulse;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
}

@-webkit-keyframes rubberBand {
  0% {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
  30% {
    -webkit-transform: scale3d(1.25, 0.75, 1);
    transform: scale3d(1.25, 0.75, 1);
  }
  40% {
    -webkit-transform: scale3d(0.75, 1.25, 1);
    transform: scale3d(0.75, 1.25, 1);
  }
  50% {
    -webkit-transform: scale3d(1.15, 0.85, 1);
    transform: scale3d(1.15, 0.85, 1);
  }
  65% {
    -webkit-transform: scale3d(0.95, 1.05, 1);
    transform: scale3d(0.95, 1.05, 1);
  }
  75% {
    -webkit-transform: scale3d(1.05, 0.95, 1);
    transform: scale3d(1.05, 0.95, 1);
  }
  to {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
@keyframes rubberBand {
  0% {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
  30% {
    -webkit-transform: scale3d(1.25, 0.75, 1);
    transform: scale3d(1.25, 0.75, 1);
  }
  40% {
    -webkit-transform: scale3d(0.75, 1.25, 1);
    transform: scale3d(0.75, 1.25, 1);
  }
  50% {
    -webkit-transform: scale3d(1.15, 0.85, 1);
    transform: scale3d(1.15, 0.85, 1);
  }
  65% {
    -webkit-transform: scale3d(0.95, 1.05, 1);
    transform: scale3d(0.95, 1.05, 1);
  }
  75% {
    -webkit-transform: scale3d(1.05, 0.95, 1);
    transform: scale3d(1.05, 0.95, 1);
  }
  to {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
.animate__rubberBand {
  -webkit-animation-name: rubberBand;
  animation-name: rubberBand;
}

@-webkit-keyframes shakeX {
  0%, to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }
  20%, 40%, 60%, 80% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }
}
@keyframes shakeX {
  0%, to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }
  20%, 40%, 60%, 80% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }
}
.animate__shakeX {
  -webkit-animation-name: shakeX;
  animation-name: shakeX;
}

@-webkit-keyframes shakeY {
  0%, to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }
  20%, 40%, 60%, 80% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }
}
@keyframes shakeY {
  0%, to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }
  20%, 40%, 60%, 80% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }
}
.animate__shakeY {
  -webkit-animation-name: shakeY;
  animation-name: shakeY;
}

@-webkit-keyframes headShake {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  6.5% {
    -webkit-transform: translateX(-6px) rotateY(-9deg);
    transform: translateX(-6px) rotateY(-9deg);
  }
  18.5% {
    -webkit-transform: translateX(5px) rotateY(7deg);
    transform: translateX(5px) rotateY(7deg);
  }
  31.5% {
    -webkit-transform: translateX(-3px) rotateY(-5deg);
    transform: translateX(-3px) rotateY(-5deg);
  }
  43.5% {
    -webkit-transform: translateX(2px) rotateY(3deg);
    transform: translateX(2px) rotateY(3deg);
  }
  50% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}
@keyframes headShake {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  6.5% {
    -webkit-transform: translateX(-6px) rotateY(-9deg);
    transform: translateX(-6px) rotateY(-9deg);
  }
  18.5% {
    -webkit-transform: translateX(5px) rotateY(7deg);
    transform: translateX(5px) rotateY(7deg);
  }
  31.5% {
    -webkit-transform: translateX(-3px) rotateY(-5deg);
    transform: translateX(-3px) rotateY(-5deg);
  }
  43.5% {
    -webkit-transform: translateX(2px) rotateY(3deg);
    transform: translateX(2px) rotateY(3deg);
  }
  50% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}
.animate__headShake {
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-name: headShake;
  animation-name: headShake;
}

@-webkit-keyframes swing {
  20% {
    -webkit-transform: rotate(15deg);
    transform: rotate(15deg);
  }
  40% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }
  60% {
    -webkit-transform: rotate(5deg);
    transform: rotate(5deg);
  }
  80% {
    -webkit-transform: rotate(-5deg);
    transform: rotate(-5deg);
  }
  to {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
  }
}
@keyframes swing {
  20% {
    -webkit-transform: rotate(15deg);
    transform: rotate(15deg);
  }
  40% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }
  60% {
    -webkit-transform: rotate(5deg);
    transform: rotate(5deg);
  }
  80% {
    -webkit-transform: rotate(-5deg);
    transform: rotate(-5deg);
  }
  to {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
  }
}
.animate__swing {
  -webkit-transform-origin: top center;
  transform-origin: top center;
  -webkit-animation-name: swing;
  animation-name: swing;
}

@-webkit-keyframes tada {
  0% {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
  10%, 20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9) rotate(-3deg);
    transform: scale3d(0.9, 0.9, 0.9) rotate(-3deg);
  }
  30%, 50%, 70%, 90% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate(3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate(3deg);
  }
  40%, 60%, 80% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate(-3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate(-3deg);
  }
  to {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
@keyframes tada {
  0% {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
  10%, 20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9) rotate(-3deg);
    transform: scale3d(0.9, 0.9, 0.9) rotate(-3deg);
  }
  30%, 50%, 70%, 90% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate(3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate(3deg);
  }
  40%, 60%, 80% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate(-3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate(-3deg);
  }
  to {
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
.animate__tada {
  -webkit-animation-name: tada;
  animation-name: tada;
}

@-webkit-keyframes wobble {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  15% {
    -webkit-transform: translate3d(-25%, 0, 0) rotate(-5deg);
    transform: translate3d(-25%, 0, 0) rotate(-5deg);
  }
  30% {
    -webkit-transform: translate3d(20%, 0, 0) rotate(3deg);
    transform: translate3d(20%, 0, 0) rotate(3deg);
  }
  45% {
    -webkit-transform: translate3d(-15%, 0, 0) rotate(-3deg);
    transform: translate3d(-15%, 0, 0) rotate(-3deg);
  }
  60% {
    -webkit-transform: translate3d(10%, 0, 0) rotate(2deg);
    transform: translate3d(10%, 0, 0) rotate(2deg);
  }
  75% {
    -webkit-transform: translate3d(-5%, 0, 0) rotate(-1deg);
    transform: translate3d(-5%, 0, 0) rotate(-1deg);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes wobble {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  15% {
    -webkit-transform: translate3d(-25%, 0, 0) rotate(-5deg);
    transform: translate3d(-25%, 0, 0) rotate(-5deg);
  }
  30% {
    -webkit-transform: translate3d(20%, 0, 0) rotate(3deg);
    transform: translate3d(20%, 0, 0) rotate(3deg);
  }
  45% {
    -webkit-transform: translate3d(-15%, 0, 0) rotate(-3deg);
    transform: translate3d(-15%, 0, 0) rotate(-3deg);
  }
  60% {
    -webkit-transform: translate3d(10%, 0, 0) rotate(2deg);
    transform: translate3d(10%, 0, 0) rotate(2deg);
  }
  75% {
    -webkit-transform: translate3d(-5%, 0, 0) rotate(-1deg);
    transform: translate3d(-5%, 0, 0) rotate(-1deg);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__wobble {
  -webkit-animation-name: wobble;
  animation-name: wobble;
}

@-webkit-keyframes jello {
  0%, 11.1%, to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  22.2% {
    -webkit-transform: skewX(-12.5deg) skewY(-12.5deg);
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }
  33.3% {
    -webkit-transform: skewX(6.25deg) skewY(6.25deg);
    transform: skewX(6.25deg) skewY(6.25deg);
  }
  44.4% {
    -webkit-transform: skewX(-3.125deg) skewY(-3.125deg);
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }
  55.5% {
    -webkit-transform: skewX(1.5625deg) skewY(1.5625deg);
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }
  66.6% {
    -webkit-transform: skewX(-0.78125deg) skewY(-0.78125deg);
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }
  77.7% {
    -webkit-transform: skewX(0.390625deg) skewY(0.390625deg);
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }
  88.8% {
    -webkit-transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
}
@keyframes jello {
  0%, 11.1%, to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  22.2% {
    -webkit-transform: skewX(-12.5deg) skewY(-12.5deg);
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }
  33.3% {
    -webkit-transform: skewX(6.25deg) skewY(6.25deg);
    transform: skewX(6.25deg) skewY(6.25deg);
  }
  44.4% {
    -webkit-transform: skewX(-3.125deg) skewY(-3.125deg);
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }
  55.5% {
    -webkit-transform: skewX(1.5625deg) skewY(1.5625deg);
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }
  66.6% {
    -webkit-transform: skewX(-0.78125deg) skewY(-0.78125deg);
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }
  77.7% {
    -webkit-transform: skewX(0.390625deg) skewY(0.390625deg);
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }
  88.8% {
    -webkit-transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
}
.animate__jello {
  -webkit-animation-name: jello;
  animation-name: jello;
  -webkit-transform-origin: center;
  transform-origin: center;
}

@-webkit-keyframes heartBeat {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  14% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }
  28% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  42% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }
  70% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
@keyframes heartBeat {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  14% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }
  28% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  42% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }
  70% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
.animate__heartBeat {
  -webkit-animation-name: heartBeat;
  animation-name: heartBeat;
  -webkit-animation-duration: 1.3s;
  animation-duration: 1.3s;
  -webkit-animation-duration: calc(var(--animate-duration) * 1.3);
  animation-duration: calc(var(--animate-duration) * 1.3);
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
}

@-webkit-keyframes backInDown {
  0% {
    -webkit-transform: translateY(-1200px) scale(0.7);
    transform: translateY(-1200px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
@keyframes backInDown {
  0% {
    -webkit-transform: translateY(-1200px) scale(0.7);
    transform: translateY(-1200px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
.animate__backInDown {
  -webkit-animation-name: backInDown;
  animation-name: backInDown;
}

@-webkit-keyframes backInLeft {
  0% {
    -webkit-transform: translateX(-2000px) scale(0.7);
    transform: translateX(-2000px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
@keyframes backInLeft {
  0% {
    -webkit-transform: translateX(-2000px) scale(0.7);
    transform: translateX(-2000px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
.animate__backInLeft {
  -webkit-animation-name: backInLeft;
  animation-name: backInLeft;
}

@-webkit-keyframes backInRight {
  0% {
    -webkit-transform: translateX(2000px) scale(0.7);
    transform: translateX(2000px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
@keyframes backInRight {
  0% {
    -webkit-transform: translateX(2000px) scale(0.7);
    transform: translateX(2000px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
.animate__backInRight {
  -webkit-animation-name: backInRight;
  animation-name: backInRight;
}

@-webkit-keyframes backInUp {
  0% {
    -webkit-transform: translateY(1200px) scale(0.7);
    transform: translateY(1200px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
@keyframes backInUp {
  0% {
    -webkit-transform: translateY(1200px) scale(0.7);
    transform: translateY(1200px) scale(0.7);
    opacity: 0.7;
  }
  80% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
}
.animate__backInUp {
  -webkit-animation-name: backInUp;
  animation-name: backInUp;
}

@-webkit-keyframes backOutDown {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateY(700px) scale(0.7);
    transform: translateY(700px) scale(0.7);
    opacity: 0.7;
  }
}
@keyframes backOutDown {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateY(700px) scale(0.7);
    transform: translateY(700px) scale(0.7);
    opacity: 0.7;
  }
}
.animate__backOutDown {
  -webkit-animation-name: backOutDown;
  animation-name: backOutDown;
}

@-webkit-keyframes backOutLeft {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateX(-2000px) scale(0.7);
    transform: translateX(-2000px) scale(0.7);
    opacity: 0.7;
  }
}
@keyframes backOutLeft {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateX(-2000px) scale(0.7);
    transform: translateX(-2000px) scale(0.7);
    opacity: 0.7;
  }
}
.animate__backOutLeft {
  -webkit-animation-name: backOutLeft;
  animation-name: backOutLeft;
}

@-webkit-keyframes backOutRight {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateX(2000px) scale(0.7);
    transform: translateX(2000px) scale(0.7);
    opacity: 0.7;
  }
}
@keyframes backOutRight {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateX(0) scale(0.7);
    transform: translateX(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateX(2000px) scale(0.7);
    transform: translateX(2000px) scale(0.7);
    opacity: 0.7;
  }
}
.animate__backOutRight {
  -webkit-animation-name: backOutRight;
  animation-name: backOutRight;
}

@-webkit-keyframes backOutUp {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateY(-700px) scale(0.7);
    transform: translateY(-700px) scale(0.7);
    opacity: 0.7;
  }
}
@keyframes backOutUp {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
    opacity: 1;
  }
  20% {
    -webkit-transform: translateY(0) scale(0.7);
    transform: translateY(0) scale(0.7);
    opacity: 0.7;
  }
  to {
    -webkit-transform: translateY(-700px) scale(0.7);
    transform: translateY(-700px) scale(0.7);
    opacity: 0.7;
  }
}
.animate__backOutUp {
  -webkit-animation-name: backOutUp;
  animation-name: backOutUp;
}

@-webkit-keyframes bounceIn {
  0%, 20%, 40%, 60%, 80%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  20% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }
  40% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(1.03, 1.03, 1.03);
    transform: scale3d(1.03, 1.03, 1.03);
  }
  80% {
    -webkit-transform: scale3d(0.97, 0.97, 0.97);
    transform: scale3d(0.97, 0.97, 0.97);
  }
  to {
    opacity: 1;
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
@keyframes bounceIn {
  0%, 20%, 40%, 60%, 80%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  20% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }
  40% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(1.03, 1.03, 1.03);
    transform: scale3d(1.03, 1.03, 1.03);
  }
  80% {
    -webkit-transform: scale3d(0.97, 0.97, 0.97);
    transform: scale3d(0.97, 0.97, 0.97);
  }
  to {
    opacity: 1;
    -webkit-transform: scaleX(1);
    transform: scaleX(1);
  }
}
.animate__bounceIn {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-duration: calc(var(--animate-duration) * 0.75);
  animation-duration: calc(var(--animate-duration) * 0.75);
  -webkit-animation-name: bounceIn;
  animation-name: bounceIn;
}

@-webkit-keyframes bounceInDown {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -3000px, 0) scaleY(3);
    transform: translate3d(0, -3000px, 0) scaleY(3);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, 25px, 0) scaleY(0.9);
    transform: translate3d(0, 25px, 0) scaleY(0.9);
  }
  75% {
    -webkit-transform: translate3d(0, -10px, 0) scaleY(0.95);
    transform: translate3d(0, -10px, 0) scaleY(0.95);
  }
  90% {
    -webkit-transform: translate3d(0, 5px, 0) scaleY(0.985);
    transform: translate3d(0, 5px, 0) scaleY(0.985);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes bounceInDown {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -3000px, 0) scaleY(3);
    transform: translate3d(0, -3000px, 0) scaleY(3);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, 25px, 0) scaleY(0.9);
    transform: translate3d(0, 25px, 0) scaleY(0.9);
  }
  75% {
    -webkit-transform: translate3d(0, -10px, 0) scaleY(0.95);
    transform: translate3d(0, -10px, 0) scaleY(0.95);
  }
  90% {
    -webkit-transform: translate3d(0, 5px, 0) scaleY(0.985);
    transform: translate3d(0, 5px, 0) scaleY(0.985);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__bounceInDown {
  -webkit-animation-name: bounceInDown;
  animation-name: bounceInDown;
}

@-webkit-keyframes bounceInLeft {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-3000px, 0, 0) scaleX(3);
    transform: translate3d(-3000px, 0, 0) scaleX(3);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(25px, 0, 0) scaleX(1);
    transform: translate3d(25px, 0, 0) scaleX(1);
  }
  75% {
    -webkit-transform: translate3d(-10px, 0, 0) scaleX(0.98);
    transform: translate3d(-10px, 0, 0) scaleX(0.98);
  }
  90% {
    -webkit-transform: translate3d(5px, 0, 0) scaleX(0.995);
    transform: translate3d(5px, 0, 0) scaleX(0.995);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes bounceInLeft {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-3000px, 0, 0) scaleX(3);
    transform: translate3d(-3000px, 0, 0) scaleX(3);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(25px, 0, 0) scaleX(1);
    transform: translate3d(25px, 0, 0) scaleX(1);
  }
  75% {
    -webkit-transform: translate3d(-10px, 0, 0) scaleX(0.98);
    transform: translate3d(-10px, 0, 0) scaleX(0.98);
  }
  90% {
    -webkit-transform: translate3d(5px, 0, 0) scaleX(0.995);
    transform: translate3d(5px, 0, 0) scaleX(0.995);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__bounceInLeft {
  -webkit-animation-name: bounceInLeft;
  animation-name: bounceInLeft;
}

@-webkit-keyframes bounceInRight {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(3000px, 0, 0) scaleX(3);
    transform: translate3d(3000px, 0, 0) scaleX(3);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(-25px, 0, 0) scaleX(1);
    transform: translate3d(-25px, 0, 0) scaleX(1);
  }
  75% {
    -webkit-transform: translate3d(10px, 0, 0) scaleX(0.98);
    transform: translate3d(10px, 0, 0) scaleX(0.98);
  }
  90% {
    -webkit-transform: translate3d(-5px, 0, 0) scaleX(0.995);
    transform: translate3d(-5px, 0, 0) scaleX(0.995);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes bounceInRight {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(3000px, 0, 0) scaleX(3);
    transform: translate3d(3000px, 0, 0) scaleX(3);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(-25px, 0, 0) scaleX(1);
    transform: translate3d(-25px, 0, 0) scaleX(1);
  }
  75% {
    -webkit-transform: translate3d(10px, 0, 0) scaleX(0.98);
    transform: translate3d(10px, 0, 0) scaleX(0.98);
  }
  90% {
    -webkit-transform: translate3d(-5px, 0, 0) scaleX(0.995);
    transform: translate3d(-5px, 0, 0) scaleX(0.995);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__bounceInRight {
  -webkit-animation-name: bounceInRight;
  animation-name: bounceInRight;
}

@-webkit-keyframes bounceInUp {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, 3000px, 0) scaleY(5);
    transform: translate3d(0, 3000px, 0) scaleY(5);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0) scaleY(0.9);
    transform: translate3d(0, -20px, 0) scaleY(0.9);
  }
  75% {
    -webkit-transform: translate3d(0, 10px, 0) scaleY(0.95);
    transform: translate3d(0, 10px, 0) scaleY(0.95);
  }
  90% {
    -webkit-transform: translate3d(0, -5px, 0) scaleY(0.985);
    transform: translate3d(0, -5px, 0) scaleY(0.985);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes bounceInUp {
  0%, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, 3000px, 0) scaleY(5);
    transform: translate3d(0, 3000px, 0) scaleY(5);
  }
  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0) scaleY(0.9);
    transform: translate3d(0, -20px, 0) scaleY(0.9);
  }
  75% {
    -webkit-transform: translate3d(0, 10px, 0) scaleY(0.95);
    transform: translate3d(0, 10px, 0) scaleY(0.95);
  }
  90% {
    -webkit-transform: translate3d(0, -5px, 0) scaleY(0.985);
    transform: translate3d(0, -5px, 0) scaleY(0.985);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__bounceInUp {
  -webkit-animation-name: bounceInUp;
  animation-name: bounceInUp;
}

@-webkit-keyframes bounceOut {
  20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }
  50%, 55% {
    opacity: 1;
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }
  to {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
}
@keyframes bounceOut {
  20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }
  50%, 55% {
    opacity: 1;
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }
  to {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
}
.animate__bounceOut {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-duration: calc(var(--animate-duration) * 0.75);
  animation-duration: calc(var(--animate-duration) * 0.75);
  -webkit-animation-name: bounceOut;
  animation-name: bounceOut;
}

@-webkit-keyframes bounceOutDown {
  20% {
    -webkit-transform: translate3d(0, 10px, 0) scaleY(0.985);
    transform: translate3d(0, 10px, 0) scaleY(0.985);
  }
  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0) scaleY(0.9);
    transform: translate3d(0, -20px, 0) scaleY(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0) scaleY(3);
    transform: translate3d(0, 2000px, 0) scaleY(3);
  }
}
@keyframes bounceOutDown {
  20% {
    -webkit-transform: translate3d(0, 10px, 0) scaleY(0.985);
    transform: translate3d(0, 10px, 0) scaleY(0.985);
  }
  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0) scaleY(0.9);
    transform: translate3d(0, -20px, 0) scaleY(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0) scaleY(3);
    transform: translate3d(0, 2000px, 0) scaleY(3);
  }
}
.animate__bounceOutDown {
  -webkit-animation-name: bounceOutDown;
  animation-name: bounceOutDown;
}

@-webkit-keyframes bounceOutLeft {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(20px, 0, 0) scaleX(0.9);
    transform: translate3d(20px, 0, 0) scaleX(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0) scaleX(2);
    transform: translate3d(-2000px, 0, 0) scaleX(2);
  }
}
@keyframes bounceOutLeft {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(20px, 0, 0) scaleX(0.9);
    transform: translate3d(20px, 0, 0) scaleX(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0) scaleX(2);
    transform: translate3d(-2000px, 0, 0) scaleX(2);
  }
}
.animate__bounceOutLeft {
  -webkit-animation-name: bounceOutLeft;
  animation-name: bounceOutLeft;
}

@-webkit-keyframes bounceOutRight {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(-20px, 0, 0) scaleX(0.9);
    transform: translate3d(-20px, 0, 0) scaleX(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0) scaleX(2);
    transform: translate3d(2000px, 0, 0) scaleX(2);
  }
}
@keyframes bounceOutRight {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(-20px, 0, 0) scaleX(0.9);
    transform: translate3d(-20px, 0, 0) scaleX(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0) scaleX(2);
    transform: translate3d(2000px, 0, 0) scaleX(2);
  }
}
.animate__bounceOutRight {
  -webkit-animation-name: bounceOutRight;
  animation-name: bounceOutRight;
}

@-webkit-keyframes bounceOutUp {
  20% {
    -webkit-transform: translate3d(0, -10px, 0) scaleY(0.985);
    transform: translate3d(0, -10px, 0) scaleY(0.985);
  }
  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, 20px, 0) scaleY(0.9);
    transform: translate3d(0, 20px, 0) scaleY(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0) scaleY(3);
    transform: translate3d(0, -2000px, 0) scaleY(3);
  }
}
@keyframes bounceOutUp {
  20% {
    -webkit-transform: translate3d(0, -10px, 0) scaleY(0.985);
    transform: translate3d(0, -10px, 0) scaleY(0.985);
  }
  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, 20px, 0) scaleY(0.9);
    transform: translate3d(0, 20px, 0) scaleY(0.9);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0) scaleY(3);
    transform: translate3d(0, -2000px, 0) scaleY(3);
  }
}
.animate__bounceOutUp {
  -webkit-animation-name: bounceOutUp;
  animation-name: bounceOutUp;
}

@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
.animate__fadeIn {
  -webkit-animation-name: fadeIn;
  animation-name: fadeIn;
}

@-webkit-keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInDown {
  -webkit-animation-name: fadeInDown;
  animation-name: fadeInDown;
}

@-webkit-keyframes fadeInDownBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInDownBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInDownBig {
  -webkit-animation-name: fadeInDownBig;
  animation-name: fadeInDownBig;
}

@-webkit-keyframes fadeInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInLeft {
  -webkit-animation-name: fadeInLeft;
  animation-name: fadeInLeft;
}

@-webkit-keyframes fadeInLeftBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInLeftBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInLeftBig {
  -webkit-animation-name: fadeInLeftBig;
  animation-name: fadeInLeftBig;
}

@-webkit-keyframes fadeInRight {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInRight {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInRight {
  -webkit-animation-name: fadeInRight;
  animation-name: fadeInRight;
}

@-webkit-keyframes fadeInRightBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInRightBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInRightBig {
  -webkit-animation-name: fadeInRightBig;
  animation-name: fadeInRightBig;
}

@-webkit-keyframes fadeInUp {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInUp {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInUp {
  -webkit-animation-name: fadeInUp;
  animation-name: fadeInUp;
}

@-webkit-keyframes fadeInUpBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInUpBig {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInUpBig {
  -webkit-animation-name: fadeInUpBig;
  animation-name: fadeInUpBig;
}

@-webkit-keyframes fadeInTopLeft {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, -100%, 0);
    transform: translate3d(-100%, -100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInTopLeft {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, -100%, 0);
    transform: translate3d(-100%, -100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInTopLeft {
  -webkit-animation-name: fadeInTopLeft;
  animation-name: fadeInTopLeft;
}

@-webkit-keyframes fadeInTopRight {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(100%, -100%, 0);
    transform: translate3d(100%, -100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInTopRight {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(100%, -100%, 0);
    transform: translate3d(100%, -100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInTopRight {
  -webkit-animation-name: fadeInTopRight;
  animation-name: fadeInTopRight;
}

@-webkit-keyframes fadeInBottomLeft {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 100%, 0);
    transform: translate3d(-100%, 100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInBottomLeft {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 100%, 0);
    transform: translate3d(-100%, 100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInBottomLeft {
  -webkit-animation-name: fadeInBottomLeft;
  animation-name: fadeInBottomLeft;
}

@-webkit-keyframes fadeInBottomRight {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(100%, 100%, 0);
    transform: translate3d(100%, 100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes fadeInBottomRight {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(100%, 100%, 0);
    transform: translate3d(100%, 100%, 0);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__fadeInBottomRight {
  -webkit-animation-name: fadeInBottomRight;
  animation-name: fadeInBottomRight;
}

@-webkit-keyframes fadeOut {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
  }
}
@keyframes fadeOut {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
  }
}
.animate__fadeOut {
  -webkit-animation-name: fadeOut;
  animation-name: fadeOut;
}

@-webkit-keyframes fadeOutDown {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}
@keyframes fadeOutDown {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}
.animate__fadeOutDown {
  -webkit-animation-name: fadeOutDown;
  animation-name: fadeOutDown;
}

@-webkit-keyframes fadeOutDownBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}
@keyframes fadeOutDownBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}
.animate__fadeOutDownBig {
  -webkit-animation-name: fadeOutDownBig;
  animation-name: fadeOutDownBig;
}

@-webkit-keyframes fadeOutLeft {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}
@keyframes fadeOutLeft {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}
.animate__fadeOutLeft {
  -webkit-animation-name: fadeOutLeft;
  animation-name: fadeOutLeft;
}

@-webkit-keyframes fadeOutLeftBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}
@keyframes fadeOutLeftBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}
.animate__fadeOutLeftBig {
  -webkit-animation-name: fadeOutLeftBig;
  animation-name: fadeOutLeftBig;
}

@-webkit-keyframes fadeOutRight {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}
@keyframes fadeOutRight {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}
.animate__fadeOutRight {
  -webkit-animation-name: fadeOutRight;
  animation-name: fadeOutRight;
}

@-webkit-keyframes fadeOutRightBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}
@keyframes fadeOutRightBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}
.animate__fadeOutRightBig {
  -webkit-animation-name: fadeOutRightBig;
  animation-name: fadeOutRightBig;
}

@-webkit-keyframes fadeOutUp {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}
@keyframes fadeOutUp {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}
.animate__fadeOutUp {
  -webkit-animation-name: fadeOutUp;
  animation-name: fadeOutUp;
}

@-webkit-keyframes fadeOutUpBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}
@keyframes fadeOutUpBig {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}
.animate__fadeOutUpBig {
  -webkit-animation-name: fadeOutUpBig;
  animation-name: fadeOutUpBig;
}

@-webkit-keyframes fadeOutTopLeft {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, -100%, 0);
    transform: translate3d(-100%, -100%, 0);
  }
}
@keyframes fadeOutTopLeft {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, -100%, 0);
    transform: translate3d(-100%, -100%, 0);
  }
}
.animate__fadeOutTopLeft {
  -webkit-animation-name: fadeOutTopLeft;
  animation-name: fadeOutTopLeft;
}

@-webkit-keyframes fadeOutTopRight {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, -100%, 0);
    transform: translate3d(100%, -100%, 0);
  }
}
@keyframes fadeOutTopRight {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, -100%, 0);
    transform: translate3d(100%, -100%, 0);
  }
}
.animate__fadeOutTopRight {
  -webkit-animation-name: fadeOutTopRight;
  animation-name: fadeOutTopRight;
}

@-webkit-keyframes fadeOutBottomRight {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 100%, 0);
    transform: translate3d(100%, 100%, 0);
  }
}
@keyframes fadeOutBottomRight {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 100%, 0);
    transform: translate3d(100%, 100%, 0);
  }
}
.animate__fadeOutBottomRight {
  -webkit-animation-name: fadeOutBottomRight;
  animation-name: fadeOutBottomRight;
}

@-webkit-keyframes fadeOutBottomLeft {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 100%, 0);
    transform: translate3d(-100%, 100%, 0);
  }
}
@keyframes fadeOutBottomLeft {
  0% {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 100%, 0);
    transform: translate3d(-100%, 100%, 0);
  }
}
.animate__fadeOutBottomLeft {
  -webkit-animation-name: fadeOutBottomLeft;
  animation-name: fadeOutBottomLeft;
}

@-webkit-keyframes flip {
  0% {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(0) rotateY(-1turn);
    transform: perspective(400px) scaleX(1) translateZ(0) rotateY(-1turn);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  40% {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-190deg);
    transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-190deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  50% {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-170deg);
    transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-170deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  80% {
    -webkit-transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translateZ(0) rotateY(0deg);
    transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translateZ(0) rotateY(0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  to {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(0) rotateY(0deg);
    transform: perspective(400px) scaleX(1) translateZ(0) rotateY(0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}
@keyframes flip {
  0% {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(0) rotateY(-1turn);
    transform: perspective(400px) scaleX(1) translateZ(0) rotateY(-1turn);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  40% {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-190deg);
    transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-190deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  50% {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-170deg);
    transform: perspective(400px) scaleX(1) translateZ(150px) rotateY(-170deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  80% {
    -webkit-transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translateZ(0) rotateY(0deg);
    transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translateZ(0) rotateY(0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  to {
    -webkit-transform: perspective(400px) scaleX(1) translateZ(0) rotateY(0deg);
    transform: perspective(400px) scaleX(1) translateZ(0) rotateY(0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}
.animate__animated.animate__flip {
  -webkit-backface-visibility: visible;
  backface-visibility: visible;
  -webkit-animation-name: flip;
  animation-name: flip;
}

@-webkit-keyframes flipInX {
  0% {
    -webkit-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateX(-20deg);
    transform: perspective(400px) rotateX(-20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  60% {
    -webkit-transform: perspective(400px) rotateX(10deg);
    transform: perspective(400px) rotateX(10deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: perspective(400px) rotateX(-5deg);
    transform: perspective(400px) rotateX(-5deg);
  }
  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}
@keyframes flipInX {
  0% {
    -webkit-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateX(-20deg);
    transform: perspective(400px) rotateX(-20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  60% {
    -webkit-transform: perspective(400px) rotateX(10deg);
    transform: perspective(400px) rotateX(10deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: perspective(400px) rotateX(-5deg);
    transform: perspective(400px) rotateX(-5deg);
  }
  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}
.animate__flipInX {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInX;
  animation-name: flipInX;
}

@-webkit-keyframes flipInY {
  0% {
    -webkit-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateY(-20deg);
    transform: perspective(400px) rotateY(-20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  60% {
    -webkit-transform: perspective(400px) rotateY(10deg);
    transform: perspective(400px) rotateY(10deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: perspective(400px) rotateY(-5deg);
    transform: perspective(400px) rotateY(-5deg);
  }
  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}
@keyframes flipInY {
  0% {
    -webkit-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateY(-20deg);
    transform: perspective(400px) rotateY(-20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  60% {
    -webkit-transform: perspective(400px) rotateY(10deg);
    transform: perspective(400px) rotateY(10deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: perspective(400px) rotateY(-5deg);
    transform: perspective(400px) rotateY(-5deg);
  }
  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}
.animate__flipInY {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInY;
  animation-name: flipInY;
}

@-webkit-keyframes flipOutX {
  0% {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
  30% {
    -webkit-transform: perspective(400px) rotateX(-20deg);
    transform: perspective(400px) rotateX(-20deg);
    opacity: 1;
  }
  to {
    -webkit-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    opacity: 0;
  }
}
@keyframes flipOutX {
  0% {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
  30% {
    -webkit-transform: perspective(400px) rotateX(-20deg);
    transform: perspective(400px) rotateX(-20deg);
    opacity: 1;
  }
  to {
    -webkit-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    opacity: 0;
  }
}
.animate__flipOutX {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-duration: calc(var(--animate-duration) * 0.75);
  animation-duration: calc(var(--animate-duration) * 0.75);
  -webkit-animation-name: flipOutX;
  animation-name: flipOutX;
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
}

@-webkit-keyframes flipOutY {
  0% {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
  30% {
    -webkit-transform: perspective(400px) rotateY(-15deg);
    transform: perspective(400px) rotateY(-15deg);
    opacity: 1;
  }
  to {
    -webkit-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    opacity: 0;
  }
}
@keyframes flipOutY {
  0% {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
  30% {
    -webkit-transform: perspective(400px) rotateY(-15deg);
    transform: perspective(400px) rotateY(-15deg);
    opacity: 1;
  }
  to {
    -webkit-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    opacity: 0;
  }
}
.animate__flipOutY {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-duration: calc(var(--animate-duration) * 0.75);
  animation-duration: calc(var(--animate-duration) * 0.75);
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipOutY;
  animation-name: flipOutY;
}

@-webkit-keyframes lightSpeedInRight {
  0% {
    -webkit-transform: translate3d(100%, 0, 0) skewX(-30deg);
    transform: translate3d(100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }
  60% {
    -webkit-transform: skewX(20deg);
    transform: skewX(20deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: skewX(-5deg);
    transform: skewX(-5deg);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes lightSpeedInRight {
  0% {
    -webkit-transform: translate3d(100%, 0, 0) skewX(-30deg);
    transform: translate3d(100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }
  60% {
    -webkit-transform: skewX(20deg);
    transform: skewX(20deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: skewX(-5deg);
    transform: skewX(-5deg);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__lightSpeedInRight {
  -webkit-animation-name: lightSpeedInRight;
  animation-name: lightSpeedInRight;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

@-webkit-keyframes lightSpeedInLeft {
  0% {
    -webkit-transform: translate3d(-100%, 0, 0) skewX(30deg);
    transform: translate3d(-100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
  60% {
    -webkit-transform: skewX(-20deg);
    transform: skewX(-20deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: skewX(5deg);
    transform: skewX(5deg);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes lightSpeedInLeft {
  0% {
    -webkit-transform: translate3d(-100%, 0, 0) skewX(30deg);
    transform: translate3d(-100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
  60% {
    -webkit-transform: skewX(-20deg);
    transform: skewX(-20deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: skewX(5deg);
    transform: skewX(5deg);
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__lightSpeedInLeft {
  -webkit-animation-name: lightSpeedInLeft;
  animation-name: lightSpeedInLeft;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

@-webkit-keyframes lightSpeedOutRight {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: translate3d(100%, 0, 0) skewX(30deg);
    transform: translate3d(100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
}
@keyframes lightSpeedOutRight {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: translate3d(100%, 0, 0) skewX(30deg);
    transform: translate3d(100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
}
.animate__lightSpeedOutRight {
  -webkit-animation-name: lightSpeedOutRight;
  animation-name: lightSpeedOutRight;
  -webkit-animation-timing-function: ease-in;
  animation-timing-function: ease-in;
}

@-webkit-keyframes lightSpeedOutLeft {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: translate3d(-100%, 0, 0) skewX(-30deg);
    transform: translate3d(-100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }
}
@keyframes lightSpeedOutLeft {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: translate3d(-100%, 0, 0) skewX(-30deg);
    transform: translate3d(-100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }
}
.animate__lightSpeedOutLeft {
  -webkit-animation-name: lightSpeedOutLeft;
  animation-name: lightSpeedOutLeft;
  -webkit-animation-timing-function: ease-in;
  animation-timing-function: ease-in;
}

@-webkit-keyframes rotateIn {
  0% {
    -webkit-transform: rotate(-200deg);
    transform: rotate(-200deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
@keyframes rotateIn {
  0% {
    -webkit-transform: rotate(-200deg);
    transform: rotate(-200deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
.animate__rotateIn {
  -webkit-animation-name: rotateIn;
  animation-name: rotateIn;
  -webkit-transform-origin: center;
  transform-origin: center;
}

@-webkit-keyframes rotateInDownLeft {
  0% {
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
@keyframes rotateInDownLeft {
  0% {
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
.animate__rotateInDownLeft {
  -webkit-animation-name: rotateInDownLeft;
  animation-name: rotateInDownLeft;
  -webkit-transform-origin: left bottom;
  transform-origin: left bottom;
}

@-webkit-keyframes rotateInDownRight {
  0% {
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
@keyframes rotateInDownRight {
  0% {
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
.animate__rotateInDownRight {
  -webkit-animation-name: rotateInDownRight;
  animation-name: rotateInDownRight;
  -webkit-transform-origin: right bottom;
  transform-origin: right bottom;
}

@-webkit-keyframes rotateInUpLeft {
  0% {
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
@keyframes rotateInUpLeft {
  0% {
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
.animate__rotateInUpLeft {
  -webkit-animation-name: rotateInUpLeft;
  animation-name: rotateInUpLeft;
  -webkit-transform-origin: left bottom;
  transform-origin: left bottom;
}

@-webkit-keyframes rotateInUpRight {
  0% {
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
@keyframes rotateInUpRight {
  0% {
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
    opacity: 1;
  }
}
.animate__rotateInUpRight {
  -webkit-animation-name: rotateInUpRight;
  animation-name: rotateInUpRight;
  -webkit-transform-origin: right bottom;
  transform-origin: right bottom;
}

@-webkit-keyframes rotateOut {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(200deg);
    transform: rotate(200deg);
    opacity: 0;
  }
}
@keyframes rotateOut {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(200deg);
    transform: rotate(200deg);
    opacity: 0;
  }
}
.animate__rotateOut {
  -webkit-animation-name: rotateOut;
  animation-name: rotateOut;
  -webkit-transform-origin: center;
  transform-origin: center;
}

@-webkit-keyframes rotateOutDownLeft {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
    opacity: 0;
  }
}
@keyframes rotateOutDownLeft {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
    opacity: 0;
  }
}
.animate__rotateOutDownLeft {
  -webkit-animation-name: rotateOutDownLeft;
  animation-name: rotateOutDownLeft;
  -webkit-transform-origin: left bottom;
  transform-origin: left bottom;
}

@-webkit-keyframes rotateOutDownRight {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
    opacity: 0;
  }
}
@keyframes rotateOutDownRight {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
    opacity: 0;
  }
}
.animate__rotateOutDownRight {
  -webkit-animation-name: rotateOutDownRight;
  animation-name: rotateOutDownRight;
  -webkit-transform-origin: right bottom;
  transform-origin: right bottom;
}

@-webkit-keyframes rotateOutUpLeft {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
    opacity: 0;
  }
}
@keyframes rotateOutUpLeft {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
    opacity: 0;
  }
}
.animate__rotateOutUpLeft {
  -webkit-animation-name: rotateOutUpLeft;
  animation-name: rotateOutUpLeft;
  -webkit-transform-origin: left bottom;
  transform-origin: left bottom;
}

@-webkit-keyframes rotateOutUpRight {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
}
@keyframes rotateOutUpRight {
  0% {
    opacity: 1;
  }
  to {
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
}
.animate__rotateOutUpRight {
  -webkit-animation-name: rotateOutUpRight;
  animation-name: rotateOutUpRight;
  -webkit-transform-origin: right bottom;
  transform-origin: right bottom;
}

@-webkit-keyframes hinge {
  0% {
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  20%, 60% {
    -webkit-transform: rotate(80deg);
    transform: rotate(80deg);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  40%, 80% {
    -webkit-transform: rotate(60deg);
    transform: rotate(60deg);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }
  to {
    -webkit-transform: translate3d(0, 700px, 0);
    transform: translate3d(0, 700px, 0);
    opacity: 0;
  }
}
@keyframes hinge {
  0% {
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  20%, 60% {
    -webkit-transform: rotate(80deg);
    transform: rotate(80deg);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  40%, 80% {
    -webkit-transform: rotate(60deg);
    transform: rotate(60deg);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }
  to {
    -webkit-transform: translate3d(0, 700px, 0);
    transform: translate3d(0, 700px, 0);
    opacity: 0;
  }
}
.animate__hinge {
  -webkit-animation-duration: 2s;
  animation-duration: 2s;
  -webkit-animation-duration: calc(var(--animate-duration) * 2);
  animation-duration: calc(var(--animate-duration) * 2);
  -webkit-animation-name: hinge;
  animation-name: hinge;
  -webkit-transform-origin: top left;
  transform-origin: top left;
}

@-webkit-keyframes jackInTheBox {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) rotate(30deg);
    transform: scale(0.1) rotate(30deg);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
  }
  50% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }
  70% {
    -webkit-transform: rotate(3deg);
    transform: rotate(3deg);
  }
  to {
    opacity: 1;
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
@keyframes jackInTheBox {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) rotate(30deg);
    transform: scale(0.1) rotate(30deg);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
  }
  50% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }
  70% {
    -webkit-transform: rotate(3deg);
    transform: rotate(3deg);
  }
  to {
    opacity: 1;
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}
.animate__jackInTheBox {
  -webkit-animation-name: jackInTheBox;
  animation-name: jackInTheBox;
}

@-webkit-keyframes rollIn {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0) rotate(-120deg);
    transform: translate3d(-100%, 0, 0) rotate(-120deg);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes rollIn {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0) rotate(-120deg);
    transform: translate3d(-100%, 0, 0) rotate(-120deg);
  }
  to {
    opacity: 1;
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__rollIn {
  -webkit-animation-name: rollIn;
  animation-name: rollIn;
}

@-webkit-keyframes rollOut {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0) rotate(120deg);
    transform: translate3d(100%, 0, 0) rotate(120deg);
  }
}
@keyframes rollOut {
  0% {
    opacity: 1;
  }
  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0) rotate(120deg);
    transform: translate3d(100%, 0, 0) rotate(120deg);
  }
}
.animate__rollOut {
  -webkit-animation-name: rollOut;
  animation-name: rollOut;
}

@-webkit-keyframes zoomIn {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  50% {
    opacity: 1;
  }
}
@keyframes zoomIn {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  50% {
    opacity: 1;
  }
}
.animate__zoomIn {
  -webkit-animation-name: zoomIn;
  animation-name: zoomIn;
}

@-webkit-keyframes zoomInDown {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
@keyframes zoomInDown {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
.animate__zoomInDown {
  -webkit-animation-name: zoomInDown;
  animation-name: zoomInDown;
}

@-webkit-keyframes zoomInLeft {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
@keyframes zoomInLeft {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
.animate__zoomInLeft {
  -webkit-animation-name: zoomInLeft;
  animation-name: zoomInLeft;
}

@-webkit-keyframes zoomInRight {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
@keyframes zoomInRight {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
.animate__zoomInRight {
  -webkit-animation-name: zoomInRight;
  animation-name: zoomInRight;
}

@-webkit-keyframes zoomInUp {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
@keyframes zoomInUp {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
.animate__zoomInUp {
  -webkit-animation-name: zoomInUp;
  animation-name: zoomInUp;
}

@-webkit-keyframes zoomOut {
  0% {
    opacity: 1;
  }
  50% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  to {
    opacity: 0;
  }
}
@keyframes zoomOut {
  0% {
    opacity: 1;
  }
  50% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  to {
    opacity: 0;
  }
}
.animate__zoomOut {
  -webkit-animation-name: zoomOut;
  animation-name: zoomOut;
}

@-webkit-keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
@keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
.animate__zoomOutDown {
  -webkit-animation-name: zoomOutDown;
  animation-name: zoomOutDown;
  -webkit-transform-origin: center bottom;
  transform-origin: center bottom;
}

@-webkit-keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
  }
  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(-2000px, 0, 0);
    transform: scale(0.1) translate3d(-2000px, 0, 0);
  }
}
@keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
  }
  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(-2000px, 0, 0);
    transform: scale(0.1) translate3d(-2000px, 0, 0);
  }
}
.animate__zoomOutLeft {
  -webkit-animation-name: zoomOutLeft;
  animation-name: zoomOutLeft;
  -webkit-transform-origin: left center;
  transform-origin: left center;
}

@-webkit-keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
  }
  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(2000px, 0, 0);
    transform: scale(0.1) translate3d(2000px, 0, 0);
  }
}
@keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
  }
  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(2000px, 0, 0);
    transform: scale(0.1) translate3d(2000px, 0, 0);
  }
}
.animate__zoomOutRight {
  -webkit-animation-name: zoomOutRight;
  animation-name: zoomOutRight;
  -webkit-transform-origin: right center;
  transform-origin: right center;
}

@-webkit-keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
@keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }
  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}
.animate__zoomOutUp {
  -webkit-animation-name: zoomOutUp;
  animation-name: zoomOutUp;
  -webkit-transform-origin: center bottom;
  transform-origin: center bottom;
}

@-webkit-keyframes slideInDown {
  0% {
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes slideInDown {
  0% {
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__slideInDown {
  -webkit-animation-name: slideInDown;
  animation-name: slideInDown;
}

@-webkit-keyframes slideInLeft {
  0% {
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes slideInLeft {
  0% {
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__slideInLeft {
  -webkit-animation-name: slideInLeft;
  animation-name: slideInLeft;
}

@-webkit-keyframes slideInRight {
  0% {
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes slideInRight {
  0% {
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__slideInRight {
  -webkit-animation-name: slideInRight;
  animation-name: slideInRight;
}

@-webkit-keyframes slideInUp {
  0% {
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
@keyframes slideInUp {
  0% {
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
    visibility: visible;
  }
  to {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
}
.animate__slideInUp {
  -webkit-animation-name: slideInUp;
  animation-name: slideInUp;
}

@-webkit-keyframes slideOutDown {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}
@keyframes slideOutDown {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}
.animate__slideOutDown {
  -webkit-animation-name: slideOutDown;
  animation-name: slideOutDown;
}

@-webkit-keyframes slideOutLeft {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}
@keyframes slideOutLeft {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}
.animate__slideOutLeft {
  -webkit-animation-name: slideOutLeft;
  animation-name: slideOutLeft;
}

@-webkit-keyframes slideOutRight {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}
@keyframes slideOutRight {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}
.animate__slideOutRight {
  -webkit-animation-name: slideOutRight;
  animation-name: slideOutRight;
}

@-webkit-keyframes slideOutUp {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}
@keyframes slideOutUp {
  0% {
    -webkit-transform: translateZ(0);
    transform: translateZ(0);
  }
  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}
.animate__slideOutUp {
  -webkit-animation-name: slideOutUp;
  animation-name: slideOutUp;
}

@keyframes float-bob-y {
  0% {
    -webkit-transform: translateY(-20px);
    transform: translateY(-20px);
  }
  50% {
    -webkit-transform: translateY(-10px);
    transform: translateY(-10px);
  }
  100% {
    -webkit-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}
@keyframes float-bob-x {
  0% {
    -webkit-transform: translateX(-100px);
    transform: translateX(-100px);
  }
  50% {
    -webkit-transform: translateX(-10px);
    transform: translateX(-10px);
  }
  100% {
    -webkit-transform: translateX(-100px);
    transform: translateX(-100px);
  }
}
body {
  font-family: "Poppins", sans-serif;
  font-weight: normal;
  font-style: normal;
  color: #1E1E1E;
}

:root {
  --animate-delay: 0.5s;
}

.my-element {
  --animate-duration: 0.5s;
}

/* width */
::-webkit-scrollbar {
  width: 10px;
}

/* Track */
::-webkit-scrollbar-track {
  background: #f1f1f1;
}

/* Handle */
::-webkit-scrollbar-thumb {
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  height: 100px;
}

.img, img {
  max-width: 100%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.f-left {
  float: left;
}

.f-right {
  float: right;
}

.fix {
  overflow: hidden;
}

a {
  text-decoration: none;
}

a,
.button {
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

a:focus,
.button:focus {
  text-decoration: none;
  outline: none;
}

a:focus,
a:hover {
  color: inherit;
  text-decoration: none;
}

a,
button {
  color: inherit;
  outline: medium none;
}

button:focus, input:focus, input:focus, textarea, textarea:focus {
  outline: 0;
}

.uppercase {
  text-transform: uppercase;
}

.capitalize {
  text-transform: capitalize;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: "Jost", sans-serif;
  font-weight: normal;
  margin-top: 0px;
  font-style: normal;
  font-weight: 400;
  text-transform: normal;
}

h1 a,
h2 a,
h3 a,
h4 a,
h5 a,
h6 a {
  color: inherit;
}

h1 {
  font-size: 40px;
  font-weight: 500;
}

h2 {
  font-size: 35px;
}

h3 {
  font-size: 28px;
}

h4 {
  font-size: 22px;
}

h5 {
  font-size: 18px;
}

h6 {
  font-size: 16px;
}

ul {
  margin: 0px;
  padding: 0px;
}

li {
  list-style: none;
}

p {
  font-size: 14px;
  font-weight: normal;
  line-height: 26px;
  color: #1E1E1E;
  margin-bottom: 15px;
}

hr {
  border-top: 0 none;
  margin: 30px 0;
  padding: 0;
}

label {
  cursor: pointer;
  font-size: 14px;
  font-weight: 400;
}

*::-moz-selection {
  text-shadow: none;
}

::-moz-selection {
  text-shadow: none;
}

::selection {
  text-shadow: none;
}

/*--
    - Input Placeholder
-----------------------------------------*/
/*--
    - Common Classes
-----------------------------------------*/
.fix {
  overflow: hidden;
}

.clear {
  clear: both;
}

/*--
    - Margin & Padding
-----------------------------------------*/
/*-- Margin Top --*/
.mt-5 {
  margin-top: 5px;
}

.mt-10 {
  margin-top: 10px;
}

.mt-15 {
  margin-top: 15px;
}

.mt-20 {
  margin-top: 20px;
}

.mt-25 {
  margin-top: 25px;
}

.mt-30 {
  margin-top: 30px;
}

.mt-35 {
  margin-top: 35px;
}

.mt-40 {
  margin-top: 40px;
}

.mt-45 {
  margin-top: 45px;
}

.mt-50 {
  margin-top: 50px;
}

.mt-55 {
  margin-top: 55px;
}

.mt-60 {
  margin-top: 60px;
}

.mt-65 {
  margin-top: 65px;
}

.mt-70 {
  margin-top: 70px;
}

.mt-75 {
  margin-top: 75px;
}

.mt-80 {
  margin-top: 80px;
}

.mt-85 {
  margin-top: 85px;
}

.mt-90 {
  margin-top: 90px;
}

.mt-95 {
  margin-top: 95px;
}

.mt-100 {
  margin-top: 100px;
}

.mt-105 {
  margin-top: 105px;
}

.mt-110 {
  margin-top: 110px;
}

.mt-115 {
  margin-top: 115px;
}

.mt-120 {
  margin-top: 120px;
}

.mt-125 {
  margin-top: 125px;
}

.mt-130 {
  margin-top: 130px;
}

.mt-135 {
  margin-top: 135px;
}

.mt-140 {
  margin-top: 140px;
}

.mt-145 {
  margin-top: 145px;
}

.mt-150 {
  margin-top: 150px;
}

.mt-155 {
  margin-top: 155px;
}

.mt-160 {
  margin-top: 160px;
}

.mt-165 {
  margin-top: 165px;
}

.mt-170 {
  margin-top: 170px;
}

.mt-175 {
  margin-top: 175px;
}

.mt-180 {
  margin-top: 180px;
}

.mt-185 {
  margin-top: 185px;
}

.mt-190 {
  margin-top: 190px;
}

.mt-195 {
  margin-top: 195px;
}

.mt-200 {
  margin-top: 200px;
}

/*-- Margin Bottom --*/
.mb-5 {
  margin-bottom: 5px;
}

.mb-10 {
  margin-bottom: 10px;
}

.mb-15 {
  margin-bottom: 15px;
}

.mb-20 {
  margin-bottom: 20px;
}

.mb-25 {
  margin-bottom: 25px;
}

.mb-30 {
  margin-bottom: 30px;
}

.mb-35 {
  margin-bottom: 35px;
}

.mb-40 {
  margin-bottom: 40px;
}

.mb-45 {
  margin-bottom: 45px;
}

.mb-50 {
  margin-bottom: 50px;
}

.mb-55 {
  margin-bottom: 55px;
}

.mb-60 {
  margin-bottom: 60px;
}

.mb-65 {
  margin-bottom: 65px;
}

.mb-70 {
  margin-bottom: 70px;
}

.mb-75 {
  margin-bottom: 75px;
}

.mb-80 {
  margin-bottom: 80px;
}

.mb-85 {
  margin-bottom: 85px;
}

.mb-90 {
  margin-bottom: 90px;
}

.mb-95 {
  margin-bottom: 95px;
}

.mb-100 {
  margin-bottom: 100px;
}

.mb-105 {
  margin-bottom: 105px;
}

.mb-110 {
  margin-bottom: 110px;
}

.mb-115 {
  margin-bottom: 115px;
}

.mb-120 {
  margin-bottom: 120px;
}

.mb-125 {
  margin-bottom: 125px;
}

.mb-130 {
  margin-bottom: 130px;
}

.mb-135 {
  margin-bottom: 135px;
}

.mb-140 {
  margin-bottom: 140px;
}

.mb-145 {
  margin-bottom: 145px;
}

.mb-150 {
  margin-bottom: 150px;
}

.mb-155 {
  margin-bottom: 155px;
}

.mb-160 {
  margin-bottom: 160px;
}

.mb-165 {
  margin-bottom: 165px;
}

.mb-170 {
  margin-bottom: 170px;
}

.mb-175 {
  margin-bottom: 175px;
}

.mb-180 {
  margin-bottom: 180px;
}

.mb-185 {
  margin-bottom: 185px;
}

.mb-190 {
  margin-bottom: 190px;
}

.mb-195 {
  margin-bottom: 195px;
}

.mb-200 {
  margin-bottom: 200px;
}

/*-- Margin Left --*/
.ml-5 {
  margin-left: 5px;
}

.ml-10 {
  margin-left: 10px;
}

.ml-15 {
  margin-left: 15px;
}

.ml-20 {
  margin-left: 20px;
}

.ml-25 {
  margin-left: 25px;
}

.ml-30 {
  margin-left: 30px;
}

.ml-35 {
  margin-left: 35px;
}

.ml-40 {
  margin-left: 40px;
}

.ml-45 {
  margin-left: 45px;
}

.ml-50 {
  margin-left: 50px;
}

.ml-55 {
  margin-left: 55px;
}

.ml-60 {
  margin-left: 60px;
}

.ml-65 {
  margin-left: 65px;
}

.ml-70 {
  margin-left: 70px;
}

.ml-75 {
  margin-left: 75px;
}

.ml-80 {
  margin-left: 80px;
}

.ml-85 {
  margin-left: 85px;
}

.ml-90 {
  margin-left: 90px;
}

.ml-95 {
  margin-left: 95px;
}

.ml-100 {
  margin-left: 100px;
}

.ml-105 {
  margin-left: 105px;
}

.ml-110 {
  margin-left: 110px;
}

.ml-115 {
  margin-left: 115px;
}

.ml-120 {
  margin-left: 120px;
}

.ml-125 {
  margin-left: 125px;
}

.ml-130 {
  margin-left: 130px;
}

.ml-135 {
  margin-left: 135px;
}

.ml-140 {
  margin-left: 140px;
}

.ml-145 {
  margin-left: 145px;
}

.ml-150 {
  margin-left: 150px;
}

.ml-155 {
  margin-left: 155px;
}

.ml-160 {
  margin-left: 160px;
}

.ml-165 {
  margin-left: 165px;
}

.ml-170 {
  margin-left: 170px;
}

.ml-175 {
  margin-left: 175px;
}

.ml-180 {
  margin-left: 180px;
}

.ml-185 {
  margin-left: 185px;
}

.ml-190 {
  margin-left: 190px;
}

.ml-195 {
  margin-left: 195px;
}

.ml-200 {
  margin-left: 200px;
}

/*-- Margin Right --*/
.mr-5 {
  margin-right: 5px;
}

.mr-10 {
  margin-right: 10px;
}

.mr-15 {
  margin-right: 15px;
}

.mr-20 {
  margin-right: 20px;
}

.mr-25 {
  margin-right: 25px;
}

.mr-30 {
  margin-right: 30px;
}

.mr-35 {
  margin-right: 35px;
}

.mr-40 {
  margin-right: 40px;
}

.mr-45 {
  margin-right: 45px;
}

.mr-50 {
  margin-right: 50px;
}

.mr-55 {
  margin-right: 55px;
}

.mr-60 {
  margin-right: 60px;
}

.mr-65 {
  margin-right: 65px;
}

.mr-70 {
  margin-right: 70px;
}

.mr-75 {
  margin-right: 75px;
}

.mr-80 {
  margin-right: 80px;
}

.mr-85 {
  margin-right: 85px;
}

.mr-90 {
  margin-right: 90px;
}

.mr-95 {
  margin-right: 95px;
}

.mr-100 {
  margin-right: 100px;
}

.mr-105 {
  margin-right: 105px;
}

.mr-110 {
  margin-right: 110px;
}

.mr-115 {
  margin-right: 115px;
}

.mr-120 {
  margin-right: 120px;
}

.mr-125 {
  margin-right: 125px;
}

.mr-130 {
  margin-right: 130px;
}

.mr-135 {
  margin-right: 135px;
}

.mr-140 {
  margin-right: 140px;
}

.mr-145 {
  margin-right: 145px;
}

.mr-150 {
  margin-right: 150px;
}

.mr-155 {
  margin-right: 155px;
}

.mr-160 {
  margin-right: 160px;
}

.mr-165 {
  margin-right: 165px;
}

.mr-170 {
  margin-right: 170px;
}

.mr-175 {
  margin-right: 175px;
}

.mr-180 {
  margin-right: 180px;
}

.mr-185 {
  margin-right: 185px;
}

.mr-190 {
  margin-right: 190px;
}

.mr-195 {
  margin-right: 195px;
}

.mr-200 {
  margin-right: 200px;
}

/*-- Padding Top --*/
.pt-5 {
  padding-top: 5px;
}

.pt-10 {
  padding-top: 10px;
}

.pt-15 {
  padding-top: 15px;
}

.pt-20 {
  padding-top: 20px;
}

.pt-25 {
  padding-top: 25px;
}

.pt-30 {
  padding-top: 30px;
}

.pt-35 {
  padding-top: 35px;
}

.pt-40 {
  padding-top: 40px;
}

.pt-45 {
  padding-top: 45px;
}

.pt-50 {
  padding-top: 50px;
}

.pt-55 {
  padding-top: 55px;
}

.pt-60 {
  padding-top: 60px;
}

.pt-65 {
  padding-top: 65px;
}

.pt-70 {
  padding-top: 70px;
}

.pt-75 {
  padding-top: 75px;
}

.pt-80 {
  padding-top: 80px;
}

.pt-85 {
  padding-top: 85px;
}

.pt-90 {
  padding-top: 90px;
}

.pt-95 {
  padding-top: 95px;
}

.pt-100 {
  padding-top: 100px;
}

.pt-105 {
  padding-top: 105px;
}

.pt-110 {
  padding-top: 110px;
}

.pt-115 {
  padding-top: 115px;
}

.pt-120 {
  padding-top: 120px;
}

.pt-125 {
  padding-top: 125px;
}

.pt-130 {
  padding-top: 130px;
}

.pt-135 {
  padding-top: 135px;
}

.pt-140 {
  padding-top: 140px;
}

.pt-145 {
  padding-top: 145px;
}

.pt-150 {
  padding-top: 150px;
}

.pt-155 {
  padding-top: 155px;
}

.pt-160 {
  padding-top: 160px;
}

.pt-165 {
  padding-top: 165px;
}

.pt-170 {
  padding-top: 170px;
}

.pt-175 {
  padding-top: 175px;
}

.pt-180 {
  padding-top: 180px;
}

.pt-185 {
  padding-top: 185px;
}

.pt-190 {
  padding-top: 190px;
}

.pt-195 {
  padding-top: 195px;
}

.pt-200 {
  padding-top: 200px;
}

/*-- Padding Bottom --*/
.pb-5 {
  padding-bottom: 5px;
}

.pb-10 {
  padding-bottom: 10px;
}

.pb-15 {
  padding-bottom: 15px;
}

.pb-20 {
  padding-bottom: 20px;
}

.pb-25 {
  padding-bottom: 25px;
}

.pb-30 {
  padding-bottom: 30px;
}

.pb-35 {
  padding-bottom: 35px;
}

.pb-40 {
  padding-bottom: 40px;
}

.pb-45 {
  padding-bottom: 45px;
}

.pb-50 {
  padding-bottom: 50px;
}

.pb-55 {
  padding-bottom: 55px;
}

.pb-60 {
  padding-bottom: 60px;
}

.pb-65 {
  padding-bottom: 65px;
}

.pb-70 {
  padding-bottom: 70px;
}

.pb-75 {
  padding-bottom: 75px;
}

.pb-80 {
  padding-bottom: 80px;
}

.pb-85 {
  padding-bottom: 85px;
}

.pb-90 {
  padding-bottom: 90px;
}

.pb-95 {
  padding-bottom: 95px;
}

.pb-100 {
  padding-bottom: 100px;
}

.pb-105 {
  padding-bottom: 105px;
}

.pb-110 {
  padding-bottom: 110px;
}

.pb-115 {
  padding-bottom: 115px;
}

.pb-120 {
  padding-bottom: 120px;
}

.pb-125 {
  padding-bottom: 125px;
}

.pb-130 {
  padding-bottom: 130px;
}

.pb-135 {
  padding-bottom: 135px;
}

.pb-140 {
  padding-bottom: 140px;
}

.pb-145 {
  padding-bottom: 145px;
}

.pb-150 {
  padding-bottom: 150px;
}

.pb-155 {
  padding-bottom: 155px;
}

.pb-160 {
  padding-bottom: 160px;
}

.pb-165 {
  padding-bottom: 165px;
}

.pb-170 {
  padding-bottom: 170px;
}

.pb-175 {
  padding-bottom: 175px;
}

.pb-180 {
  padding-bottom: 180px;
}

.pb-185 {
  padding-bottom: 185px;
}

.pb-190 {
  padding-bottom: 190px;
}

.pb-195 {
  padding-bottom: 195px;
}

.pb-200 {
  padding-bottom: 200px;
}

/*-- Padding Left --*/
.pl-5 {
  padding-left: 5px;
}

.pl-10 {
  padding-left: 10px;
}

.pl-15 {
  padding-left: 15px;
}

.pl-20 {
  padding-left: 20px;
}

.pl-25 {
  padding-left: 25px;
}

.pl-30 {
  padding-left: 30px;
}

.pl-35 {
  padding-left: 35px;
}

.pl-40 {
  padding-left: 40px;
}

.pl-45 {
  padding-left: 45px;
}

.pl-50 {
  padding-left: 50px;
}

.pl-55 {
  padding-left: 55px;
}

.pl-60 {
  padding-left: 60px;
}

.pl-65 {
  padding-left: 65px;
}

.pl-70 {
  padding-left: 70px;
}

.pl-75 {
  padding-left: 75px;
}

.pl-80 {
  padding-left: 80px;
}

.pl-85 {
  padding-left: 85px;
}

.pl-90 {
  padding-left: 90px;
}

.pl-95 {
  padding-left: 95px;
}

.pl-100 {
  padding-left: 100px;
}

.pl-105 {
  padding-left: 105px;
}

.pl-110 {
  padding-left: 110px;
}

.pl-115 {
  padding-left: 115px;
}

.pl-120 {
  padding-left: 120px;
}

.pl-125 {
  padding-left: 125px;
}

.pl-130 {
  padding-left: 130px;
}

.pl-135 {
  padding-left: 135px;
}

.pl-140 {
  padding-left: 140px;
}

.pl-145 {
  padding-left: 145px;
}

.pl-150 {
  padding-left: 150px;
}

.pl-155 {
  padding-left: 155px;
}

.pl-160 {
  padding-left: 160px;
}

.pl-165 {
  padding-left: 165px;
}

.pl-170 {
  padding-left: 170px;
}

.pl-175 {
  padding-left: 175px;
}

.pl-180 {
  padding-left: 180px;
}

.pl-185 {
  padding-left: 185px;
}

.pl-190 {
  padding-left: 190px;
}

.pl-195 {
  padding-left: 195px;
}

.pl-200 {
  padding-left: 200px;
}

/*-- Padding Right --*/
.pr-5 {
  padding-right: 5px;
}

.pr-10 {
  padding-right: 10px;
}

.pr-15 {
  padding-right: 15px;
}

.pr-20 {
  padding-right: 20px;
}

.pr-25 {
  padding-right: 25px;
}

.pr-30 {
  padding-right: 30px;
}

.pr-35 {
  padding-right: 35px;
}

.pr-40 {
  padding-right: 40px;
}

.pr-45 {
  padding-right: 45px;
}

.pr-50 {
  padding-right: 50px;
}

.pr-55 {
  padding-right: 55px;
}

.pr-60 {
  padding-right: 60px;
}

.pr-65 {
  padding-right: 65px;
}

.pr-70 {
  padding-right: 70px;
}

.pr-75 {
  padding-right: 75px;
}

.pr-80 {
  padding-right: 80px;
}

.pr-85 {
  padding-right: 85px;
}

.pr-90 {
  padding-right: 90px;
}

.pr-95 {
  padding-right: 95px;
}

.pr-100 {
  padding-right: 100px;
}

.pr-105 {
  padding-right: 105px;
}

.pr-110 {
  padding-right: 110px;
}

.pr-115 {
  padding-right: 115px;
}

.pr-120 {
  padding-right: 120px;
}

.pr-125 {
  padding-right: 125px;
}

.pr-130 {
  padding-right: 130px;
}

.pr-135 {
  padding-right: 135px;
}

.pr-140 {
  padding-right: 140px;
}

.pr-145 {
  padding-right: 145px;
}

.pr-150 {
  padding-right: 150px;
}

.pr-155 {
  padding-right: 155px;
}

.pr-160 {
  padding-right: 160px;
}

.pr-165 {
  padding-right: 165px;
}

.pr-170 {
  padding-right: 170px;
}

.pr-175 {
  padding-right: 175px;
}

.pr-180 {
  padding-right: 180px;
}

.pr-185 {
  padding-right: 185px;
}

.pr-190 {
  padding-right: 190px;
}

.pr-195 {
  padding-right: 195px;
}

.pr-200 {
  padding-right: 200px;
}

.main-menu nav > ul > li.menu-item-has-children > a::after {
  content: "\f078";
  font-family: "Font Awesome 5 Pro";
  font-size: 13px;
  margin-left: 4px;
  font-weight: 600;
}

@font-face {
  font-family: "icomoon";
  src: url("../fonts/icomoon.eot?rsttim");
  src: url("fonts/icomoon.eot?rsttim#iefix") format("embedded-opentype"), url("../fonts/icomoon.ttf") format("truetype"), url("../fonts/icomoon.woff") format("woff"), url("../fonts/icomoon.svg") format("svg");
  font-weight: normal;
  font-style: normal;
  font-display: block;
}
[class^=icon-], [class*=" icon-"] {
  /* use !important to prevent issues with browser extensions that change fonts */
  font-family: "icomoon" !important;
  speak: never;
  font-style: normal;
  font-weight: normal;
  font-variant: normal;
  text-transform: none;
  line-height: 1;
  /* Better Font Rendering =========== */
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.icon-search:before {
  content: "\e900";
}

.icon-ticket:before {
  content: "\e900";
  color: #7a24bd;
}

.section-padding {
  padding-top: 116px;
}

.section-wrapper {
  margin-bottom: 30px;
  z-index: 9999;
  position: relative;
}

.mb-xl {
  margin-bottom: 119px !important;
}

.butn:link,
.butn:visited {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  font-size: 16px;
  text-transform: uppercase;
  text-decoration: none;
  background-color: #5e16bd;
  background-image: linear-gradient(90deg, #501aa8, #870de8);
  padding: 20px 25px;
  margin-right: 13px;
  border-radius: 6px;
  border: none;
  color: #fff;
  position: relative;
  overflow: hidden;
  transition: all 0.2s ease-in-out;
}

.butn::before {
  background: #fff;
  content: "";
  height: 155px;
  opacity: 0;
  position: absolute;
  top: -50px;
  transform: rotate(35deg);
  width: 50px;
  transition: all 3000ms cubic-bezier(0.19, 1, 0.22, 1);
}

.butn::after {
  background: #fff;
  content: "";
  height: 20rem;
  opacity: 0;
  position: absolute;
  top: -50px;
  transform: rotate(35deg);
  transition: all 2000ms cubic-bezier(0.19, 1, 0.22, 1);
  width: 8rem;
}

.butn__new::before {
  left: -50%;
}

.butn__new::after {
  left: -100%;
}

.butn:hover,
.butn:active {
  transform: translateY(-3px);
  color: #fff;
  box-shadow: 0 10px 20px 0 rgba(0, 0, 0, 0.3);
}

.butn__new:hover::before {
  left: 120%;
  opacity: 0.5s;
}

.butn__new:hover::after {
  left: 200%;
  opacity: 0.6;
}

.butn span {
  z-index: 20;
}

.btn {
  color: #fff;
  cursor: pointer;
  font-size: 16px;
  font-weight: 400;
  line-height: 45px;
  margin: 0 0 2em;
  max-width: 160px;
  position: relative;
  text-decoration: none;
  text-transform: uppercase;
  width: 100%;
}
@media (min-width: 600px) {
  .btn {
    margin: 0 1em 2em;
  }
}
.btn:hover {
  text-decoration: none;
}

.btn-1 {
  color: #fff;
  display: inline-block;
  text-transform: uppercase;
  font-size: 16px;
  font-weight: 600;
  color: #fff;
  border-radius: 6px;
}
.btn-1 svg {
  height: 60px;
  left: -35px;
  position: absolute;
  top: 0;
  width: 148%;
}
.btn-1 rect {
  fill: none;
  stroke: #fff;
  stroke-width: 2;
  stroke-dasharray: 422, 0;
  transition: all 0.35s linear;
  border-radius: 6px;
}

.btn-1:hover {
  background: transparent;
  font-weight: 900;
  letter-spacing: 1px;
  color: #fff;
}
.btn-1:hover rect {
  stroke-width: 5;
  stroke-dasharray: 15, 310;
  stroke-dashoffset: 48;
  transition: all 1.35s cubic-bezier(0.19, 1, 0.22, 1);
}

a.btn.btn-1 img {
  padding-left: 10px;
}

a.btn.btn-1.btn-2 svg {
  left: -12px;
  width: 130%;
}

.header_btn {
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.header_btn:hover {
  background-color: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  box-shadow: rgba(17, 12, 46, 0.15) 0px 48px 100px 0px;
  transform: translateY(-2px);
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  border-radius: 6px;
}

.cmn_btn.sponsor_btn {
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.cmn_btn.sponsor_btn:hover {
  background-color: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  box-shadow: rgba(169, 169, 170, 0.15) 0px 48px 100px 0px;
  transform: translateY(-2px);
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  border-radius: 6px;
}

/*
===========================
header area start 
===========================
*/
.header_area {
  position: absolute;
  z-index: 9999;
  right: 0;
  left: 0;
  top: 30px;
  background: #fff;
  margin-left: 64px;
  margin-right: 64px;
  border-radius: 10px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0 40px;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.logo img {
  width: 210px;
}

.main-menu ul li {
  display: inline-block;
  margin-right: 33px;
  position: relative;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.main-menu ul li a {
  display: block;
  padding: 47px 0;
  text-transform: uppercase;
  color: #404040;
  font-weight: 600;
}
.main-menu ul li a:hover {
  color: #2D07A9;
}

.main-menu ul li .submenu {
  position: absolute;
  left: 0;
  top: 100%;
  width: 200px;
  box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;
  background-color: #fff;
  padding: 15px 0;
  opacity: 0;
  visibility: hidden;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  z-index: 99999999;
}
.main-menu ul li .submenu li {
  display: block;
  padding: 14px;
  padding-bottom: 2px;
}
.main-menu ul li .submenu li a {
  padding: 0;
}

.main-menu ul li:hover .submenu {
  visibility: visible;
  opacity: 1;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
  top: 110%;
}

.search {
  position: relative;
  margin: 0 30px;
}
.search button {
  background: transparent;
  border: 0;
  position: absolute;
  right: 33px;
}
.search button i {
  color: #404040;
}
.search input {
  border: 0;
  color: #B8B8B8;
  width: 155px;
  padding-right: 79px;
}
.search input::placeholder {
  text-transform: capitalize;
  color: #BCBCBC;
  letter-spacing: 2px;
}

.cmn_btn {
  border: 1px solid #2A06A8;
  display: inline-block;
  padding: 20px 25px;
  text-transform: uppercase;
  font-size: 16px;
  font-weight: 600;
  color: #2D07A9;
  border-radius: 6px;
}
.cmn_btn span {
  display: inline-block;
  margin-left: 10px;
}

.logo {
  flex: 2;
}

.main-menu-two ul li a {
  color: #14133B;
  font-weight: 600;
}

.header_btn.header_btn_two {
  border: 1px solid #1578E9;
  color: #1578E9;
}
.header_btn.header_btn_two span {
  color: #1578E9 !important;
}

.hero-two {
  background-color: #F8FBFF;
  padding-bottom: 0;
  position: relative;
  padding-left: 105px;
  padding-right: 105px;
  position: relative;
  border-radius: 6px;
  overflow: hidden;
  padding-bottom: 100px;
  padding-top: 10px;
}

.hero-two-wrap {
  background-color: #1578E9;
  border-radius: 20px;
  padding: 90px 0;
  padding-bottom: 0;
}

.header_area.header_area_two {
  position: static;
}

.hero-right {
  display: flex;
  justify-content: right;
  padding-left: 538px;
}

.event_date li {
  display: inline-block;
  margin-right: 30px;
  color: #fff;
  margin-bottom: 20px;
}
.event_date li img {
  padding-right: 10px;
}

.hero-content-two {
  display: flex;
  align-items: center;
}

.hero-title-two {
  font-size: 65px;
  line-height: 85px;
  font-weight: 800;
  color: #fff;
}

.hero-main-content {
  position: relative;
}

.hero-two-image {
  position: relative;
}

.circle-top-left {
  left: -51px;
  top: 22px;
  animation: float-bob-x 10s linear infinite;
}

.circle-top-right {
  left: 28%;
  bottom: 40px;
  animation: zoomIn 1s linear forwards;
}

.angle-bottom-right {
  right: -232px;
  opacity: 1;
  top: 41%;
  z-index: 9;
}

.h2_ractangle_00 {
  top: 40px;
  left: 880px;
  opacity: 0.3;
  animation: animationFramesTwo 20s linear infinite;
}

.h2_ractangle_01 {
  top: 216px;
  right: 124px;
  opacity: 0.3;
  animation: animationFramesFive 20s linear infinite;
}

.h2_ractangle_02 {
  right: 400px;
  bottom: 270px;
  opacity: 0.3;
  display: none;
}

.h2_ractangle_03 {
  bottom: 67px;
  left: 64%;
  opacity: 0.3;
  animation: animationFramesTwo 20s linear infinite;
}

.position-absolute.h2_ractangle_04 {
  top: 62%;
  right: 23%;
  opacity: 0.3;
  z-index: 9;
  animation: animationFramesOne 20s linear infinite;
}

a.cmn_btn.header_btn.header_btn_two img {
  padding-left: 10px;
}

.h2_ractangle_05 {
  bottom: 440px;
  left: 10px;
  opacity: 0.3;
  animation: animationFramesOne 20s linear infinite;
}

.h2_ractangle_10 {
  right: 23px;
  bottom: 215px;
  opacity: 0.3;
  animation: animationFramesTwo 20s linear infinite;
}

.shape-element {
  left: 380px;
  top: -13px;
  opacity: 0.3;
}

.header_area.sticky-bar {
  position: fixed;
  left: 0;
  right: 0;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
  top: 0;
  z-index: 99999999999999;
  margin: 0;
  border-radius: 0;
  box-shadow: rgba(0, 0, 0, 0.07) 0px 7px 51px;
}

.sticky-bar .main-menu ul li a {
  padding: 30px 0;
}

/*
===========================
Hero area start 
===========================
*/
.hero_area {
  background-image: url("../img/hero/hero_img.png");
  background-size: cover;
  background-position: center center;
  background-repeat: no-repeat;
  height: 100%;
  width: 100%;
  position: relative;
  z-index: 9;
  overflow: hidden;
}
.hero_area::before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background: linear-gradient(90deg, rgba(123, 38, 190, 0.9) 0%, rgba(42, 6, 168, 0.9) 100%);
  z-index: -1;
}

@-webkit-keyframes zoomeffect {
  0% {
    background-position: center;
    transform: scale(1, 1);
  }
  50% {
    background-position: center;
    transform: scale(2, 2);
  }
  100% {
    background-position: center;
    transform: scale(1, 1);
  }
}
@keyframes zoomeffect {
  0% {
    background-position: center;
    transform: scale(1, 1);
  }
  50% {
    background-position: center;
    transform: scale(2, 2);
  }
  100% {
    background-position: center;
    transform: scale(1, 1);
  }
}
.position-absolute.ractangle_02 {
  right: -112px;
  bottom: 0;
}

.position-absolute.ractangle_01 {
  top: 0;
  left: -114px;
}

.position-absolute.ractangle_03 {
  bottom: 50px;
  left: 40px;
  animation: zoomIn 5s linear forwards;
}

.position-absolute.ractangle_04 {
  bottom: 440px;
  left: 15px;
  opacity: 0.2;
  animation: pulse 2s linear infinite;
}

.position-absolute.ractangle_05 {
  top: 420px;
  left: 454px;
  opacity: 0.2;
  animation: animationFramesTwo 20s linear infinite;
}

.position-absolute.ractangle_06 {
  top: 810px;
  left: 480px;
  opacity: 0.2;
  animation: animationFramesFour 20s linear infinite;
}

.position-absolute.ractangle_10 {
  bottom: 215px;
  right: 35px;
  opacity: 0.2;
  animation: animationFramesOne 30s linear infinite;
}

.position-absolute.ractangle_09 {
  top: 350px;
  right: 130px;
  opacity: 0.3;
  animation: animationFramesOne 30s linear infinite;
}

.position-absolute.ractangle_08 {
  top: 680px;
  right: 500px;
  opacity: 0.2;
  animation: animationFramesOne 20s linear infinite;
}

.position-absolute.ractangle_07 {
  bottom: 35px;
  right: 715px;
  opacity: 0.2;
  animation: animationFramesTwo 20s linear infinite;
}

.hero_content {
  padding-top: 320px;
  padding-bottom: 143px;
}
.hero_content .hero_subtite {
  font-size: 24px;
  font-weight: 600;
  color: #fff;
  text-transform: capitalize;
  margin-bottom: 20px;
  display: inline-block;
  position: relative;
}
.hero_content .hero_subtite::before {
  position: absolute;
  content: "";
  width: 272px;
  height: 2px;
  background: transparent linear-gradient(90deg, #FFFFFF 0%, #80808000 100%) 0% 0% no-repeat padding-box;
  border-radius: 10px;
  top: 50%;
  left: 162%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.hero_content .hero_subtite::after {
  position: absolute;
  content: "";
  width: 272px;
  height: 2px;
  background: transparent linear-gradient(270deg, #FFFFFF 0%, #80808000 100%) 0% 0% no-repeat padding-box;
  border-radius: 10px;
  top: 50%;
  right: 162%;
}
.hero_content .hero_title {
  font-size: 80px;
  font-weight: 800;
  color: #fff;
  margin-bottom: 35px;
  line-height: 100px;
}
.hero_content .event_date {
  display: flex;
  justify-content: center;
  margin-bottom: 25px;
  flex-wrap: wrap;
}
.hero_content .event_date li {
  color: #fff;
  text-transform: capitalize;
  font-weight: 600;
  letter-spacing: 2px;
}
.hero_content .event_date li:first-child {
  margin-right: 30px;
}
.hero_content .event_date li img {
  margin-right: 10px;
}

.hbox {
  display: inline-block;
  padding: 16px 40px;
  background: linear-gradient(#7042C2 60%, white 40%);
  border-radius: 10px;
  border: 1px solid #FFFFFF;
  margin-right: 13px;
  margin-bottom: 30px;
}
.hbox .clText {
  font-size: 35px;
  font-weight: 700;
  color: #fff;
  padding-bottom: 31px;
  display: inline-block;
}
.hbox .days, .hbox .seconds, .hbox .minutes, .hbox .hours {
  color: #3399CC;
  font-size: 14px;
  font-weight: 600;
  text-transform: uppercase;
  padding: 0;
}
.hbox .hours {
  color: #21CC33;
}
.hbox .minutes {
  color: #FE9933;
}
.hbox .seconds {
  color: #CC3366;
}

.position-absolute.ractangle_11 {
  position: absolute;
  left: 50%;
  transform: translateX(-50%);
  top: 24%;
}

img.position-absolute.ractangle_00 {
  left: 1036px;
  top: 16%;
  animation: animationFramesThree 30s linear infinite;
  opacity: 0.2;
}

/*
===========================
team area start 
===========================
*/
.team-area {
  position: relative;
  overflow: hidden;
}

.teamshape-01 {
  top: 133px;
  left: 992px;
}

.sub-title {
  color: #3399CC;
  text-transform: uppercase;
  font-size: 18px;
  font-weight: 600;
  line-height: 32px;
  display: inline-block;
}

.section-title {
  font-size: 40px;
  font-weight: 700;
  text-transform: capitalize;
  color: #0D1422;
  line-height: 65px;
}

.arrow-btn {
  font-size: 16px;
  color: #7B26BE;
  font-weight: 600;
  text-transform: capitalize;
}

.arrow-btn span {
  display: inline-block;
  background: #7B26BE;
  width: 29px;
  height: 2px;
  margin-left: 18px;
  transform: translateY(-4px);
}

.team-wrapper {
  display: flex;
  flex-wrap: wrap;
}

.arrow-up-right {
  position: absolute;
  top: 69px;
  right: 39px;
  opacity: 0;
}

.profile {
  position: relative;
  background: linear-gradient(90deg, rgba(123, 38, 190, 0.75) 0%, rgba(42, 6, 168, 0.75) 100%);
  overflow: hidden;
  cursor: pointer;
  border: 0;
  width: 277px;
  margin-bottom: 30px;
}
.profile__thumb {
  -webkit-transition: all 0.4s ease-out 0s;
  -moz-transition: all 0.4s ease-out 0s;
  -ms-transition: all 0.4s ease-out 0s;
  -o-transition: all 0.4s ease-out 0s;
  transition: all 0.4s ease-out 0s;
  width: 100%;
}
.profile__thumb img {
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.profile__thumb::before {
  position: absolute;
  left: 0;
  bottom: 0;
  height: 100%;
  width: 100%;
  content: "";
  -webkit-transition: all 0.4s ease-out 0s;
  -moz-transition: all 0.4s ease-out 0s;
  -ms-transition: all 0.4s ease-out 0s;
  -o-transition: all 0.4s ease-out 0s;
  transition: all 0.4s ease-out 0s;
  background: linear-gradient(to bottom, rgba(25, 25, 26, 0.75) 0%, rgba(42, 6, 168, 0.75) 100%);
  opacity: 0;
}
.profile__content {
  transform: scale(0);
  -webkit-transition: all 0.4s ease-out 0s;
  -moz-transition: all 0.4s ease-out 0s;
  -ms-transition: all 0.4s ease-out 0s;
  -o-transition: all 0.4s ease-out 0s;
  transition: all 0.4s ease-out 0s;
  transform-origin: left;
}
.profile .profile-name {
  font-size: 22px;
  font-weight: 700;
  text-transform: uppercase;
  line-height: 35px;
  transform: rotate(-90deg);
  position: absolute;
  bottom: 141px;
  left: -34px;
  color: #fff;
}
.profile .profile-title {
  font-size: 16px;
  font-weight: 700;
  text-transform: uppercase;
  line-height: 35px;
  transform: rotate(-90deg);
  position: absolute;
  bottom: 107px;
  left: 38px;
  color: #fff;
}
.profile:hover .profile__thumb {
  transform: scale(0.8);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  border-radius: 6px;
}
.profile:hover .profile__thumb img {
  border-radius: 6px;
}
.profile:hover .profile__content {
  transform: scale(1);
  -webkit-transition: all 0.4s ease-out 0s;
  -moz-transition: all 0.4s ease-out 0s;
  -ms-transition: all 0.4s ease-out 0s;
  -o-transition: all 0.4s ease-out 0s;
  transition: all 0.4s ease-out 0s;
}
.profile:hover .profile__thumb::before {
  opacity: 0.3;
  -webkit-transition: all 0.4s ease-out 0s;
  -moz-transition: all 0.4s ease-out 0s;
  -ms-transition: all 0.4s ease-out 0s;
  -o-transition: all 0.4s ease-out 0s;
  transition: all 0.4s ease-out 0s;
}
.profile:hover .arrow-up-right {
  opacity: 1;
  -webkit-transition: all 0.4s ease-out 0s;
  -moz-transition: all 0.4s ease-out 0s;
  -ms-transition: all 0.4s ease-out 0s;
  -o-transition: all 0.4s ease-out 0s;
  transition: all 0.4s ease-out 0s;
}

.speakerTwo {
  position: relative;
  margin-right: 30px;
  margin-bottom: 30px;
  position: relative;
  cursor: pointer;
  overflow: hidden;
}
.speakerTwo__thumb {
  position: relative;
}
.speakerTwo__thumb img {
  width: 100%;
}
.speakerTwo__thumb::before {
  position: absolute;
  content: "";
  bottom: 0;
  left: 0;
  height: 0%;
  width: 100%;
  background: transparent linear-gradient(180deg, #FFFFFF00 0%, #1578E9 100%) 0% 0% no-repeat padding-box;
  border-radius: 10px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.speakerTwo__content {
  display: flex;
  justify-content: space-between;
  position: absolute;
  bottom: -100px;
  left: 0;
  color: #fff;
  align-items: center;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  padding: 0 60px;
  width: 100%;
}
.speakerTwo:hover .speakerTwo__thumb::before {
  height: 100%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.speakerTwo:hover .speakerTwo__content {
  bottom: 60px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}

.speaker-name-two {
  font-size: 22px;
  font-weight: 700;
  text-transform: uppercase;
}

.speaker-title-two {
  color: #fff;
  position: relative;
}
.speaker-title-two::before {
  position: absolute;
  content: "";
  left: 50%;
  width: 164px;
  height: 1px;
  background-color: #fff;
  top: 50%;
  transform: translateY(-50%);
}

.prev-arrow-blog.team-arrow-left.slick-arrow {
  position: absolute;
  right: 250px;
  top: -103px;
  background: transparent;
  border: 2px solid #1578E9;
  padding: 9px 16px;
  display: inline-block;
  border-radius: 6px;
  font-weight: 700;
  color: #1578E9;
  z-index: 9999999;
}

.next-arrow-blog.team-arrow-right.slick-arrow {
  right: 194px;
  color: #1578E9;
  border: 2px solid #1578E9;
}

.profile__content.profileInner__content {
  transform: scale(1);
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 20px;
}

.profile-name.profile-name-two {
  transform: rotate(0);
  left: 0;
  bottom: 0;
  position: static;
  margin-bottom: 0;
  text-transform: capitalize;
  color: #7B26BE;
}

.profile-title.profile-title-two {
  transform: rotate(0);
  left: 0;
  bottom: 0;
  position: static;
  color: #1E1E1E;
}

.profile.profileInner {
  background: #FFFFFF 0% 0% no-repeat padding-box;
  box-shadow: 0px 3px 20px #0000001A;
  background: transparent;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
  overflow: hidden;
}
.profile.profileInner:hover .profile__thumb {
  transform: scale(1);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  border-radius: 6px;
}
.profile.profileInner:hover .profile__thumb img {
  border-radius: 6px;
}
.profile.profileInner:hover .team-inner-social {
  opacity: 1;
  visibility: visible;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.profile.profileInner:hover .arrow-team {
  transform: rotate(-30deg);
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.team-area-inner {
  padding-bottom: 30px;
}

.team-wrapper-inner {
  justify-content: space-between;
}

.team-inner-social ul li {
  display: inline-block;
  height: 40px;
  width: 40px;
  margin-right: 0px;
  border: 2px solid #fff;
  border-radius: 50px;
  line-height: 40px;
  text-align: center;
  font-size: 18px;
  color: #fff;
}

.team-inner-social {
  background: #a633fe;
  background: linear-gradient(180deg, #a633fe 0%, #2300db 100%);
  padding: 15px 0;
  text-align: center;
  position: absolute;
  transform: translateY(-181px);
  width: 100%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
  opacity: 0;
  visibility: hidden;
}

.arrow-team {
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.speaker-shapes-inner {
  position: relative;
}

.speaker-area-inner-content h2 {
  font-size: 40px;
  line-height: 3.438rem;
}

.speakerTwo-inner {
  margin-right: 0;
}

.speaker-inner-content {
  padding: 0 30px;
  display: block;
  text-align: center;
}

.speaker-name-inner {
  font-size: 18px;
  font-weight: 600;
}

.speaker-title-inner {
  font-size: 16px;
}
.speaker-title-inner::before {
  width: 0;
}

.wrap-speaker.wrap-speaker-inner {
  margin-right: 0;
}

.speaker-area-inner-content p {
  font-size: 16px;
  line-height: 1.75rem;
}

.speaker-area-inner {
  position: relative;
  overflow: hidden;
}

.speaker-inner-01 {
  bottom: 200px;
  left: 100px;
}

.speaker-inner-02 {
  bottom: 50px;
  right: -249px;
}

.teamshape-02 {
  top: 140px;
  left: 10px;
  opacity: 0.1;
}

.teamshape-03 {
  top: 320px;
  left: 105px;
  opacity: 0.1;
}

.teamshape-04 {
  bottom: 50px;
  left: 30px;
  opacity: 0.1;
}

.teamshape-05 {
  right: 700px;
  top: 38px;
  opacity: 0.1;
}

.teamshape-06 {
  right: 700px;
  top: 185px;
  opacity: 0.1;
}

.teamshape-07 {
  right: 180px;
  top: 160px;
  opacity: 0.1;
}

.teamshape-08 {
  right: 17px;
  top: 215px;
  opacity: 0.1;
}

.teamshape-09 {
  bottom: 18px;
  right: 230px;
  opacity: 0.1;
}

.teamshape-10 {
  bottom: 18px;
  right: 50px;
  opacity: 0.1;
}

/*
===========================
about area start 
===========================
*/
.about-area {
  background-image: url("../img/about/section-wrapper-about.png");
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  padding-bottom: 90px;
  position: relative;
  overflow: hidden;
}
.about-area::before {
  position: absolute;
  content: "";
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  background: #2A06A8 0% 0% no-repeat padding-box;
  opacity: 0.85;
}

.about_para {
  color: #fff;
  line-height: 28px;
  padding-top: 10px;
  font-size: 16px;
  text-align: justify;
}

.about_event_date {
  padding-top: 25px;
  display: flex;
  justify-content: space-between;
  margin-bottom: 60px;
  align-items: center;
}
.about_event_date li {
  color: #fff;
  position: relative;
  position: relative;
  padding-left: 51px;
}
.about_event_date li img {
  display: inline-block;
}

.about-sub-title {
  padding-bottom: 15px;
}

.bg-circle {
  height: 42px;
  width: 42px;
  background: #fff;
  border-radius: 5px;
  display: inline-block;
  line-height: 42px;
  text-align: center;
  margin-right: 15px;
  position: absolute;
  left: 0px;
}

.cmn_btn.about_btn {
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  border-radius: 6px;
  color: #fff;
}
.cmn_btn.about_btn img {
  padding-left: 15px;
}

a.cmn_btn.about_btn.butn.butn__new.cmn_btn.readmore.readmore-two.readmore-btn.thm-btn {
  background: #1578e9;
}

.about_images {
  position: relative;
}

.down_image {
  position: absolute;
  right: -4%;
  bottom: -16%;
}

.about_pattern_01 {
  bottom: 0;
  right: 0;
}

img.about_pattern_02 {
  top: 0;
  left: 0;
}

.readmore.readmore-two {
  background-color: #1578E9;
  color: #fff;
  border: 0;
}
.readmore.readmore-two:hover {
  color: #fff;
}
.readmore.readmore-two img {
  padding-left: 10px;
}

.home-two-list {
  display: flex;
  border-bottom: 1px dashed #BFBFBF;
  padding-bottom: 30px;
}
.home-two-list ul li {
  margin-right: 40px;
  font-size: 16px;
  line-height: 25px;
  color: #14133B;
  font-weight: 600;
}
.home-two-list ul li i {
  color: #1578E9;
  display: inline-block;
  padding-right: 15px;
  margin-bottom: 20px;
}

.about-wrapper {
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
}

.about-para-two {
  padding-top: 30px;
  margin-bottom: 60px;
}
.about-para-two p {
  color: #1E1E1E;
  line-height: 28px;
  font-size: 16px;
}

.about-two-images {
  position: relative;
}

.back-image {
  position: absolute;
  top: 45px;
  right: -67px;
  z-index: -1;
}

.back-image-02 {
  position: absolute;
  right: -53px;
  z-index: 9;
  top: 350px;
}

.about-two-images {
  position: relative;
  flex: 2;
  padding-left: 200px;
}

.about-two-content {
  flex: 3;
}

.circle-roteate {
  position: absolute;
  left: 158px;
  top: 0px;
  width: 88%;
}

a#play-video\ play-video-two {
  top: 50%;
  left: 67%;
  transform: translate(-50%, -50%);
}

span.bg-back {
  position: absolute;
  display: inline-block;
  background: #AACEF7;
  height: 100%;
  width: 66%;
  opacity: 0.9;
  z-index: -1;
  bottom: -15%;
  left: 47%;
  border-radius: 6px;
}

.ab-shape-01 {
  position: absolute;
  left: -43px;
  z-index: -1;
  top: -131px;
}

.ab-sec-01 {
  position: absolute;
  left: -8%;
  top: 0;
}

.about-area-two {
  position: relative;
  margin-bottom: 145px;
  overflow: hidden;
}

.ab-sec-01 {
  position: absolute;
  left: -12%;
  top: -21px;
}

.ab-sec-02 {
  position: absolute;
  top: 43%;
  left: 2%;
  animation: float-bob-y 5s linear infinite;
}

.ab-sec-03 {
  position: absolute;
  left: -7%;
  top: 34%;
  animation: float-bob-x 20s linear infinite;
}

img.ab-sec-04 {
  position: absolute;
  top: 72%;
  z-index: -2;
  left: -3%;
  opacity: 0.4;
}

.sub-title-two {
  color: #1578E9;
}

.schedule-area-two {
  background-color: #F8FBFF;
}

.calculator_05 {
  top: 240px;
  left: 97px;
  animation: float-bob-y 2s linear infinite;
}

.calculator_06 {
  bottom: 240px;
  right: 93px;
  animation: float-bob-y 2s linear infinite;
}

.schedule-buttons-two .nav-pills .nav-link.active, .nav-pills .show > .nav-link {
  color: #fff !important;
  background: #1578E9;
  border-radius: 3px;
}

.schedule_btn_two {
  border: 1px solid #1578E9;
  color: #1578E9;
}

#confer-color-two {
  color: #1578E9;
}

.section-mt {
  margin-top: 116px;
}

.section-mb {
  margin-bottom: 116px;
}

.home-two-list-two {
  border-top: 1px dashed #bfbfbf;
  border-bottom: 0;
  padding-top: 30px;
}

.about-para-two-inner {
  margin-bottom: 40px;
  padding-top: 0;
}

.about-two-images-inner {
  position: relative;
}

.wrapper {
  display: inline-block;
  position: absolute;
  top: 40%;
  left: 40%;
  transform: translate(-50%, -50%);
}

.video-main {
  position: relative;
  display: inline-block;
}

.video {
  height: 50px;
  width: 50px;
  line-height: 50px;
  text-align: center;
  border-radius: 100%;
  background: transparent;
  color: #fff;
  display: inline-block;
  background: #FE9933;
  z-index: 999;
}

.video.video-inner {
  background: #CC3366;
}

@keyframes waves {
  0% {
    -webkit-transform: scale(0.2, 0.2);
    transform: scale(0.2, 0.2);
    opacity: 0;
    -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=0)";
  }
  50% {
    opacity: 0.9;
    -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=90)";
  }
  100% {
    -webkit-transform: scale(0.9, 0.9);
    transform: scale(0.9, 0.9);
    opacity: 0;
    -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=0)";
  }
}
.checkbutton::before {
  position: absolute;
  content: "";
  background-image: url("../img/about/check.png");
  height: 100%;
  width: 100%;
  background-repeat: no-repeat;
  top: 69%;
  left: 69%;
  transform: translate(-50%, -50%);
}

.checkbutton.checkbutton-inner::before {
  position: absolute;
  content: "";
  background-image: url("../img/about/speaker.png");
  height: 100%;
  width: 100%;
  background-repeat: no-repeat;
  top: 75%;
  left: 72%;
  transform: translate(-50%, -50%);
}

.waves.waves-inner {
  background: #CC3366;
}

.waves {
  position: absolute;
  width: 150px;
  height: 150px;
  background: #FE9933;
  opacity: 0;
  -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=0)";
  border-radius: 100%;
  right: -50px;
  bottom: -50px;
  z-index: -1;
  -webkit-animation: waves 3s ease-in-out infinite;
  animation: waves 3s ease-in-out infinite;
}

.wave-1 {
  -webkit-animation-delay: 0s;
  animation-delay: 0s;
}

.wave-2 {
  -webkit-animation-delay: 1s;
  animation-delay: 1s;
}

.wave-3 {
  -webkit-animation-delay: 2s;
  animation-delay: 2s;
}

.wrapper.wrapper-inner {
  top: 80%;
  left: 29%;
}

.shape-inner-about {
  left: 40px;
  top: 160px;
}

.shape-inner-about.about-inner-02 {
  left: 11%;
}

.plane_02.about-inner-05 {
  top: 50%;
  right: 50px;
}

.process-inner {
  background: #F6F2FB;
  position: relative;
  padding-bottom: 100px;
  overflow: hidden;
}

.processInner {
  position: relative;
  z-index: 2;
  width: 370px;
  height: 248px;
  background-color: #ffffff;
  margin: 124px 0;
  border-left: solid 1px #7B26BE;
  border-right: solid 1px #7B26BE;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.processInner:hover {
  background: #A633FE;
  border: 1px solid #fff;
  padding: 10px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.processInner:hover .processInner__content h4 {
  color: #fff;
}
.processInner:hover .processInner__content p {
  color: #fff;
}
.processInner__thumb {
  position: relative;
  z-index: 6;
  margin-bottom: 20px;
}
.processInner__content {
  position: relative;
  z-index: 9;
  text-align: center;
}
.processInner__content h4 {
  font-size: 22px;
  font-weight: 700;
  color: #1E1E1E;
  line-height: 35px;
  margin-bottom: 20px;
}
.processInner__content p {
  font-size: 16px;
  line-height: 28px;
  color: #1E1E1E;
  font-weight: 600;
}

.processInner:before,
.processInner:after {
  content: "";
  position: absolute;
  z-index: 1;
  width: 261.63px;
  height: 261.63px;
  -webkit-transform: scaleY(0.5774) rotate(-45deg);
  -ms-transform: scaleY(0.5774) rotate(-45deg);
  transform: scaleY(0.5774) rotate(-45deg);
  background-color: inherit;
  left: 53.1852px;
}

.processInner:before {
  top: -130.8148px;
  border-top: solid 1.4142px #7B26BE;
  border-right: solid 1.4142px #7B26BE;
}

.processInner:after {
  bottom: -130.8148px;
  border-bottom: solid 1.4142px #7B26BE;
  border-left: solid 1.4142px #7B26BE;
}

.processInner.mt-top-minus {
  margin-top: 0;
}

.process_active {
  background: #A633FE;
}

.process_active h4 {
  color: #fff;
}

.process_active p {
  color: #fff;
}

.register-area.process-register {
  margin-top: 0;
}

.sheduling-shapes-process-bottom {
  bottom: 250px;
  right: 100px;
  position: absolute;
  z-index: 99;
}

.counter-area {
  padding-bottom: 60px;
}

.counterWrapper {
  border: 2px solid #F6F2FB;
  padding: 60px 50px;
  position: relative;
  margin-bottom: 30px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  cursor: pointer;
}
.counterWrapper:hover {
  box-shadow: 0px 3px 20px #7000C833;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.counterWrapper::before {
  content: "";
  position: absolute;
  left: 67%;
  top: 15px;
  height: 100%;
  width: 100%;
  background-image: url("../img/about-inner/counter-dotte.png");
  background-repeat: no-repeat;
}
.counterWrapper__thumb {
  margin-bottom: 30px;
}
.counterWrapper__content p {
  font-size: 16px;
  line-height: 28px;
  color: #1E1E1E;
  font-weight: 600;
}

.bg-theme {
  color: #7B26BE;
}

.extrabold {
  font-weight: 800;
}

.counter-area {
  overflow: hidden;
  position: relative;
}

.counter-02 {
  transform: rotate(-36deg);
  top: 40%;
  left: 5%;
}

.counter-01 {
  transform: rotate(-36deg);
  top: 24%;
  left: 0%;
}

.counter-03 {
  right: 104px;
  top: 300px;
  transform: rotate(-30deg);
}

.counter-04 {
  right: 104px;
  bottom: 30px;
  transform: rotate(-30deg);
}

.ticket-area.ticket-area-inner {
  background: transparent;
}
.ticket-area.ticket-area-inner::before {
  background: #fff;
}

.schedule-area-inner {
  background: transparent;
}

.inner_btn i {
  display: inline-block;
  padding-left: 10px;
}

.cmn_btn.about_btn.butn.butn__new.inner_btn.inner_btn_two {
  background: #fff;
  color: #7B26BE;
  border: 1px solid #7B26BE;
}

.counterWrapper.counter-wrapper-two {
  padding: 30px;
}

.service-title {
  font-size: 22px;
  font-weight: 700;
  line-height: 25px;
}

.counterWrapper.counter-wrapper-two::before {
  content: "";
  position: absolute;
  top: 10px;
  height: 100%;
  right: 25px;
  width: 100%;
  background-image: url("../img/about-inner/sm-pattern.png");
  background-repeat: no-repeat;
}

.schedule-about {
  margin-bottom: 120px;
}

.conference-area {
  display: flex;
  overflow: hidden;
  flex-wrap: wrap;
  margin-bottom: 30px;
}

.conference-item {
  margin-bottom: 30px;
}

.conference-slider {
  position: relative;
}
.conference-slider::before {
  position: absolute;
  right: 193px;
  width: 170px;
  height: 1px;
  background: #fff;
  content: "";
  z-index: 99999;
  bottom: 112px;
}

.slider-nav {
  position: absolute;
  bottom: 100px;
  color: #fff;
  left: 48%;
  font-size: 18px;
  text-transform: capitalize;
}
.slider-nav::before {
  position: absolute;
  right: 0;
  width: 170px;
  height: 1px;
  background: #fff;
  content: "";
}

.prev-arrow-blog.team-arrow-left.conference-prev {
  position: absolute;
  right: 122px;
  top: 77%;
  background: transparent;
  border: 2px solid #ffff;
  padding: 9px 16px;
  display: inline-block;
  border-radius: 6px;
  font-weight: 700;
  color: #ffff;
  z-index: 9999999;
}

.next-arrow-blog.team-arrow-right.conference-next {
  right: 58px;
  color: #ffff;
  border: 2px solid #ffff;
  top: 77%;
}

.conference-text {
  display: flex;
  bottom: 38px;
  position: absolute;
  left: 170px;
  color: #fff;
  align-items: center;
}

.conference-img {
  position: relative;
}

#innervideo {
  left: -65px;
  top: 70px;
  position: absolute;
}

.conference-01 h2 {
  font-size: 40px;
  font-weight: 700;
  color: #FE9933;
  line-height: 65px;
}
.conference-01 p {
  font-size: 16px;
  color: #fff;
  line-height: 28px;
}

.scheduling-time-wrapper {
  background: #E4C3FE;
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
  padding: 20px 60px;
  align-items: center;
  padding-bottom: 0;
  position: relative;
  z-index: 9;
  margin-bottom: 40px;
  padding-left: 0;
}

.scheduling-para {
  font-size: 16px;
  color: #7000C8;
  font-weight: 600;
  text-transform: uppercase;
}

.time01 {
  position: absolute;
  left: 0;
  top: 0;
}

.time02 {
  position: absolute;
  right: 0;
  bottom: 0;
  z-index: -1;
}

.section-details-title {
  margin-bottom: 20px;
}

.scheduling-details p {
  font-size: 16px;
  line-height: 28px;
  color: #1E1E1E;
}

.time-bg {
  background: #F6F2FB;
  padding: 20px 36px;
  position: relative;
  margin-bottom: 30px;
}
.time-bg::before {
  position: absolute;
  left: 0;
  background: #7B26BE;
  content: "";
  height: 100%;
  top: 0;
  width: 6px;
}
.time-bg p {
  font-size: 16px;
  line-height: 28px;
  color: #1E1E1E;
}

.time-details-two p {
  font-size: 16px;
  line-height: 28px;
  color: #1E1E1E;
  margin-bottom: 40px;
}

.color-bg {
  color: #1E1E1E;
  padding-bottom: 10px;
}

.color-bg-2 {
  color: #1E1E1E !important;
}

.benefitTwo {
  border: 1px solid #F6F2FB;
  padding: 28px 10px;
  border-radius: 8px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.benefitTwo:hover {
  box-shadow: 0px 3px 20px #7B26BE33;
  border-radius: 8px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}

.benefit__thumb.benefitTwoThumb img {
  margin-bottom: 15px;
}

.benefit__content.benefitTwoContent h3 {
  padding-bottom: 10px;
  font-size: 16px;
  font-weight: 600;
  text-transform: capitalize;
}

.details-service-title {
  font-size: 22px;
  line-height: 35px;
  color: #1E1E1E;
  font-weight: 700;
  text-transform: capitalize;
}

.schedule-mentor {
  background: #7B26BE;
  padding: 40px;
  border-radius: 6px;
  box-shadow: 0px 13px 26px #7B26BE33;
  margin-bottom: 120px;
}

.scheduleMentor {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
}

.scheduleMentor__thumb {
  flex: 1;
  margin-right: 30px;
  margin-bottom: 20px;
}

.scheduleMentor__content {
  flex: 11;
}

.mentor-social ul li {
  display: inline-block;
  margin-right: 4px;
  border: 1px solid #fff;
  border-radius: 50px;
  height: 25px;
  width: 25px;
  color: #fff;
  text-align: center;
  line-height: 25px;
  font-size: 13px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  cursor: pointer;
}
.mentor-social ul li:hover {
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  background: #a633fe;
  background: linear-gradient(60deg, #a633fe 0%, #2300db 100%);
}

.mentor-name {
  font-size: 22px;
  font-weight: 700;
  color: #fff;
  text-transform: capitalize;
  line-height: 35px;
  margin-bottom: 0;
}

.mentor-title {
  font-size: 16px;
  color: #fff;
  line-height: 28px;
  text-transform: capitalize;
  margin-bottom: 17px;
  display: inline-block;
}

.scheduleMentor__content p {
  color: #fff;
  font-size: 16px;
  line-height: 28px;
  margin-bottom: 31px;
}

.scheduling-time {
  position: relative;
  overflow: hidden;
}

.d-1 {
  top: 120px;
  right: 190px;
}

.d-2 {
  right: 90px;
  top: 120px;
}

.d-3 {
  right: 164px;
  top: 260px;
}

.team-para-inner {
  font-size: 16px;
  line-height: 28px;
}

.why-choose {
  background: #F7F4FC;
  position: relative;
}

.benefitThree {
  background: #fff;
}

.accoridion-section.why-choose {
  background: #fff;
}

.c-1 {
  top: 22%;
}

.c-2 {
  bottom: 10%;
  right: 5%;
}

.footer-area.remove-mt {
  margin-top: 0;
}

/*
===========================
play video start 
===========================
*/
.video-play-button {
  position: absolute;
  z-index: 10;
  top: 73%;
  left: 77%;
  transform: translateX(-50%) translateY(-50%);
  box-sizing: content-box;
  display: block;
  width: 32px;
  height: 44px;
  /* background: #fa183d; */
  border-radius: 50%;
  padding: 18px 20px 18px 28px;
  overflow: hidden;
}

.video-play-button:before {
  content: "";
  position: absolute;
  z-index: 0;
  left: 50%;
  top: 50%;
  transform: translateX(-50%) translateY(-50%);
  display: block;
  width: 80px;
  height: 80px;
  background: transparent;
  border-radius: 50%;
  animation: pulse-border 1500ms ease-out infinite;
}

.video-play-button:after {
  content: "";
  position: absolute;
  z-index: 1;
  left: 50%;
  top: 50%;
  transform: translateX(-50%) translateY(-50%);
  display: block;
  width: 80px;
  height: 80px;
  background: transparent;
  border-radius: 50%;
  border: 1px solid #fff;
  transition: all 200ms;
}

.video-play-button:hover:after {
  background-color: #da0528;
}

.video-play-button img {
  position: relative;
  z-index: 3;
  max-width: 100%;
  width: auto;
  height: auto;
}

.video-play-button span {
  display: block;
  position: relative;
  z-index: 3;
  width: 0;
  height: 0;
  border-left: 32px solid #fff;
  border-top: 22px solid transparent;
  border-bottom: 22px solid transparent;
}

@keyframes pulse-border {
  0% {
    transform: translateX(-50%) translateY(-50%) translateZ(0) scale(1);
    opacity: 1;
  }
  100% {
    transform: translateX(-50%) translateY(-50%) translateZ(0) scale(1.5);
    opacity: 0;
  }
}
.video-overlay {
  position: fixed;
  z-index: -1;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: rgba(0, 0, 0, 0.8);
  opacity: 0;
  transition: all ease 500ms;
}

.video-overlay.open {
  position: fixed;
  z-index: 999999999999;
  opacity: 1;
}

.video-overlay-close {
  position: absolute;
  z-index: 1000;
  top: 15px;
  right: 20px;
  font-size: 36px;
  line-height: 1;
  font-weight: 400;
  color: #fff;
  text-decoration: none;
  cursor: pointer;
  transition: all 200ms;
}

.video-overlay-close:hover {
  background-color: #7B26BE;
}

.video-overlay iframe {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translateX(-50%) translateY(-50%);
  /* width: 90%; */
  /* height: auto; */
  box-shadow: 0 0 15px rgba(0, 0, 0, 0.75);
}

/*
===========================
schedule area start 
===========================
*/
.schedule-buttons {
  display: flex;
  justify-content: center;
  align-items: center;
  padding-top: 30px;
  margin-bottom: 60px;
  flex-wrap: wrap;
}

.text-center {
  text-align: center !important;
}

.large_btn {
  border: 1px solid #7B26BE;
  padding: 14px 25px;
  text-transform: uppercase;
  font-size: 16px;
  font-weight: 600;
  color: #2D07A9;
  border-radius: 6px;
}

.schedule-buttons .nav.nav-pills .nav-item .nav-link {
  padding: 7px 10px;
  color: #7B7B7B;
  margin-right: 11px;
}

.schedule-buttons .nav.nav-pills .nav-item {
  margin-right: 0;
}

.cmn_btn.schedule_btn {
  margin-left: 20px;
  padding: 21px 40px;
  border: 1px solid #7B26BE;
  color: #7B26BE;
  font-weight: 700;
}
.cmn_btn.schedule_btn img {
  padding-left: 15px;
}

.nav-pills .nav-link.active, .nav-pills .show > .nav-link {
  color: #fff !important;
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  border-radius: 3px;
}

.schedule_subtitle {
  margin-bottom: 10px;
}

.scheduleWrapper {
  display: flex;
  align-items: center;
}
.scheduleWrapper__thumb {
  margin-right: 30px;
}
.scheduleWrapper__content span:first-child {
  color: #717171;
  line-height: 28px;
}

.confer-color {
  color: #7B26BE;
  line-height: 28px;
  font-weight: 700;
  text-transform: uppercase;
  margin-left: 25px;
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.conference-title {
  font-size: 22px;
  font-weight: 700;
  color: #1E1E1E;
  line-height: 35px;
  padding-top: 10px;
  padding-bottom: 6px;
}

.conference-para {
  color: #1E1E1E;
  line-height: 28px;
  margin-bottom: 26px;
  font-size: 16px;
  font-weight: 400;
}

.scheduleWrapper {
  margin-bottom: 30px;
  background: #FFFFFF 0% 0% no-repeat padding-box;
  box-shadow: 0px 13px 26px #3399CC33;
  border-radius: 8px;
  padding: 60px;
}

.schedulePerson {
  display: flex;
  align-items: center;
}
.schedulePerson__content {
  padding-top: 10px;
}
.schedulePerson__content p {
  margin: 0;
  text-transform: capitalize;
  font-size: 16px;
  line-height: 28px;
  color: #1E1E1E !important;
}

.speaker-name {
  color: #3399CC !important;
  font-weight: 600;
}

.wrap-speaker {
  margin-right: 60px;
}

.plane_01 {
  top: 410px;
  right: 210px;
  animation: float-bob-y 2s linear infinite;
}

.schedule-area {
  position: relative;
  overflow: hidden;
  margin-bottom: 90px;
  overflow: hidden;
}

.plane_02 {
  top: 120px;
  right: 95px;
  animation: float-bob-x 12s linear infinite;
}

.plane_03 {
  top: 177px;
  right: -3px;
}

.plane_04 {
  top: 260px;
  right: 66px;
  animation: float-bob-y 2s linear infinite;
}

.plane_05 {
  bottom: 0;
}

img.plane_06 {
  bottom: 383px;
  left: 12%;
}

.scheduleWrapper__thumb {
  overflow: hidden;
}

.scheduleWrapper__thumb img {
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.scheduleWrapper__thumb img:hover {
  transform: scale(1.2);
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.pay-0 {
  animation: float-bob-y 2s linear infinite;
}

.schedule_btn.schedule_btn_two {
  color: #1578E9;
  border: 1px solid #1578E9;
}

.large_btn.large_btn_two {
  border: 0;
  background: #fff;
}

span.quantity {
  color: #1E1E1E !important;
}

/*
===========================
ticket area start 
===========================
*/
.ticket-area {
  background-image: url("../img/ticket/chair.png");
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  padding-bottom: 120px;
  position: relative;
  overflow: hidden;
}
.ticket-area::before {
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  height: 100%;
  width: 100%;
  background: #2A06A8 0% 0% no-repeat padding-box;
  z-index: 2;
  opacity: 0.8;
}

.ticket-desing {
  display: flex;
  z-index: 999;
  position: relative;
  flex-wrap: wrap;
}

.ticket-wrapper {
  background: #fff;
  padding: 7px;
  text-align: center;
  position: relative;
  border-radius: 15px;
  margin-right: 25px;
  margin-bottom: 70px;
}

.ticket_thumb img {
  padding-top: 8px;
}

.ticket {
  background: #F9F1FF;
  padding: 18px;
}
.ticket__body ul li {
  font-size: 16px;
  color: #404040;
  line-height: 32px;
  border-bottom: 1px dashed #D5D5D5;
  margin-bottom: 7px;
  padding-bottom: 5px;
}
.ticket__footer {
  padding-top: 10px;
  padding-bottom: 60px;
}

.ticket-title {
  padding: 17px;
  padding-bottom: 18px;
  font-size: 24px;
  font-weight: 700;
  color: #1E1E1E;
  text-transform: uppercase;
}

.calculator-wrapper {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.calculator {
  padding: 10px 18px;
  background: #fff;
}
.calculator h3 {
  font-size: 30px;
  font-weight: 700;
  line-height: 28px;
  color: #7B26BE;
  margin-bottom: 0;
}
.calculator h3 img {
  padding-left: 5px;
  transform: translateY(-3px);
}

.counter {
  padding: 8px;
  background: #fff;
  margin-left: 2px;
  max-width: 148px;
}

.counter-wrapper {
  display: flex;
  justify-content: space-between;
}
.counter-wrapper span {
  margin-right: 40px;
  display: inline-block;
  color: #404040;
  font-weight: 600;
  font-size: 23px;
}

.ticket_btn {
  background: #ffff;
  display: inline-block;
  height: 92px;
  width: 92px;
  border-radius: 50px;
  line-height: 92px;
  text-align: center;
  outline: 9px solid #2A06A8;
  position: absolute;
  left: 50%;
  transform: translateX(-50%);
  bottom: -50px;
}

.ticket-area .container {
  padding: 0;
}

.r-pattern-0 {
  z-index: 9;
  top: 0;
  left: -6%;
  opacity: 0.4;
}

.r-pattern-1 {
  z-index: 9;
  bottom: 0;
  right: -6%;
  opacity: 0.4;
}

.ticket-area-two {
  position: relative;
  background: #F8FBFF;
  padding-bottom: 120px;
  padding-top: 415px;
}

.ticket-wrapper {
  margin-right: 14px;
  box-shadow: 0px 3px 6px #1578E938;
  border: 10px solid #FFFFFF;
  cursor: pointer;
}

.discount-1 {
  right: 0;
  bottom: 107px;
}

.ticket.ticket-two {
  background-color: #E1EFFF;
  position: relative;
  z-index: 99;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.ticket.ticket-two::before {
  position: absolute;
  bottom: 0;
  left: 0;
  height: 100%;
  width: 100%;
  background-image: url("../img/home-two/price/Subtraction7.png");
  background-repeat: no-repeat;
  background-size: cover;
  content: "";
  opacity: 1;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  z-index: -2;
  transform: scale(0);
}
.ticket.ticket-two:hover::before {
  transform: scale(1);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.ticket.ticket-two:hover .ticket-title {
  color: #fff;
}
.ticket.ticket-two:hover ul li {
  color: #fff;
}

.color-black {
  color: #14133B !important;
}

a.ticket_btn.ticket_btn_two {
  background: #1578E9;
  border: 1px dashed #fff;
  outline: 5px solid #1578e9;
  bottom: -52px;
  overflow: visible;
  z-index: 9;
}

.border-design {
  display: inline-block;
  width: 135px;
  height: 135px;
  background: #fff;
  border-radius: 50%;
  position: absolute;
  transform: translate(-50%, -50%);
  bottom: -141px;
}

.ticket__footer {
  padding-top: 10px;
  padding-bottom: 85px;
}

.border-design {
  display: inline-block;
  width: 135px;
  height: 135px;
  background: #fff;
  border-radius: 50%;
  position: absolute;
  transform: translate(-50%, -50%);
  bottom: -141px;
  box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;
}

.border-design {
  display: inline-block;
  width: 120px;
  height: 120px;
  border-radius: 50%;
  position: absolute;
  outline: 9px solid #fff;
  transform: translate(-50%, -50%);
  bottom: -125px;
  box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;
  outline-offset: -1px;
}

a.cmn_btn.sponsor_btn.sponsor_btn_two {
  border: 1px solid #1578E9;
  color: #1578E9;
}

a.ticket_btn.ticket_btn_two img {
  width: 35%;
}

.close-01 {
  top: 140px;
  left: 65px;
  opacity: 0.2;
}

.close-01 {
  top: 140px;
  left: 65px;
  opacity: 0.2;
}

.close-02 {
  left: 160px;
  top: 520px;
  opacity: 0.2;
}

.close-03 {
  bottom: 109px;
  left: 85px;
  opacity: 0.2;
}

.close-04 {
  bottom: 60px;
  left: 500px;
  opacity: 0.2;
}

.close-05 {
  right: 530px;
  top: 40px;
  opacity: 0.2;
}

.close-06 {
  right: 226px;
  top: 212px;
  opacity: 0.2;
}

.close-07 {
  right: 65px;
  top: 290px;
  opacity: 0.2;
}

.close-08 {
  bottom: 110px;
  right: 95px;
  opacity: 0.2;
}

.close-09 {
  right: 150px;
  bottom: 110px;
  opacity: 0.2;
}

.ticket-price {
  padding-bottom: 15px;
}
.ticket-price h2 {
  text-transform: capitalize;
}

.currencey-color {
  color: #7B26BE;
  font-weight: 700;
  font-size: 50px;
  line-height: 4.063rem;
}

.ticket.ticket-design-two {
  background: transparent;
  padding: 20px 0;
}

.body-two-design {
  margin-bottom: 30px;
}

.ticket-wrapper-design-two {
  border: 0;
  margin-bottom: 30px;
  padding: 0px 50px;
  box-shadow: 0px 3px 20px #7B26BE33;
  border-radius: 8px;
  padding-bottom: 20px;
  padding-top: 10px;
  position: relative;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.ticket-wrapper-design-two::before {
  position: absolute;
  top: 0;
  left: 0;
  height: 7px;
  background: #7B26BE;
  content: "";
  width: 0%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.ticket-wrapper-design-two::after {
  position: absolute;
  bottom: 0;
  left: 0;
  height: 7px;
  background: #7B26BE;
  content: "";
  width: 0%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.ticket-wrapper-design-two:hover::before {
  width: 100%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.ticket-wrapper-design-two:hover::after {
  width: 100%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.calculation {
  display: flex;
  justify-content: space-around;
  align-items: center;
  padding: 30px;
  position: relative;
}

.result-field {
  background: #F2E2FF;
  padding: 13px 42px;
  border-radius: 50px;
  color: #1E1E1E;
  font-size: 30px;
  line-height: 2.188rem;
  font-weight: 700;
}

span#decrement {
  display: inline-block;
  font-size: 19px;
  height: 30px;
  width: 30px;
  background: #2A06A8;
  color: #fff;
  line-height: 30px;
  border-radius: 50px;
  position: absolute;
  left: 60px;
}

span#increment {
  display: inline-block;
  font-size: 19px;
  height: 30px;
  width: 30px;
  background: #2A06A8;
  color: #fff;
  line-height: 30px;
  border-radius: 50px;
  position: absolute;
  right: 60px;
}

.cmn_btn.bookig_btn {
  background: transparent;
  border: 1px solid #7B26BE;
  color: #7B26BE;
}

.ticket-area-design-two {
  padding-bottom: 0;
}

.ticket-design-two-shape-01 {
  bottom: 10px;
  left: 100px;
  opacity: 1;
}

.ticket-design-two-shape-02 {
  right: 0;
  bottom: 0;
}

.ticket-header-inner-two {
  text-align: left;
}

.ticket-body-inner-two {
  text-align: left;
}
.ticket-body-inner-two ul li {
  border: 0;
  position: relative;
  padding-left: 25px;
}
.ticket-body-inner-two ul li::before {
  position: absolute;
  left: 0;
  height: 100%;
  width: 100%;
  background-image: url("../img/contact/check-mark.png");
  content: "";
  top: 75%;
  transform: translateY(-50%);
  background-repeat: no-repeat;
}

.ticket-body-inner-two {
  text-align: left;
  padding-top: 10px;
  padding-bottom: 10px;
}
.ticket-body-inner-two::before {
  position: absolute;
  top: 243px;
  left: 0;
  height: 1px;
  width: 100%;
  border-bottom: 1px dashed #D5D5D5;
  content: "";
}
.ticket-body-inner-two::after {
  position: absolute;
  bottom: 120px;
  left: 0;
  height: 1px;
  width: 100%;
  border-bottom: 1px dashed #D5D5D5;
  content: "";
}

.ticket-title-pad {
  padding-left: 0;
  font-size: 22px;
  line-height: 35px;
  text-transform: capitalize;
  padding-bottom: 10px;
}

.ticket-price p {
  font-size: 16px;
  line-height: 28px;
  margin-bottom: 5px;
}

.ticket-price-inner h2 {
  margin-bottom: 15px;
}

.ticket-para-inner {
  font-size: 16px;
}

.inner-ticket {
  padding: 0 28px;
  padding-bottom: 10px;
}

/*
===========================
sponsor area start 
===========================
*/
.sponsor-area {
  position: relative;
  overflow: hidden;
}

.sponsor-wrap {
  display: flex;
  justify-content: space-between;
  background-color: #F3F5F7;
  padding: 6px;
  flex-wrap: wrap;
  padding-bottom: 0;
}

.sponsor {
  padding: 70px 60px;
  background-color: #fff;
  position: relative;
  z-index: 9;
}
.sponsor::before {
  position: absolute;
  left: 0;
  top: 0;
  height: 100%;
  width: 0%;
  background-color: rgba(0, 0, 0, 0.2);
  content: "";
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  z-index: -2;
}
.sponsor::after {
  position: absolute;
  right: 0;
  top: 0;
  height: 100%;
  width: 0%;
  background-color: rgba(0, 0, 0, 0.2);
  content: "";
  opacity: 0.3;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  z-index: -1;
}
.sponsor:hover::before {
  width: 100%;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.sponsor:hover::after {
  width: 100%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.mbadd {
  margin-bottom: 60px;
}

img.sp-01 {
  top: 85px;
  left: 270px;
}

img.sp-03 {
  left: 448px;
  top: 146px;
}

img.sp-02 {
  left: 20px;
  top: 435px;
}

.sp-04 {
  top: 225px;
  left: 290px;
  z-index: -2;
}

.sponsor_btn img {
  padding-left: 10px;
}

.sponsor_thumb img:hover {
  transform: translateY(-10px);
  transition: 0.2s;
}

.speaker-details {
  position: relative;
  overflow: hidden;
}

.speaker-single-d {
  bottom: 210px;
  left: 80px;
  opacity: 0.6;
}

.speaker-single-1 {
  right: 60px;
  top: 100px;
}

.speakerDetailsImage__content span {
  font-size: 16px;
  color: #7B26BE;
  line-height: 1.75rem;
  display: inline-block;
  margin-bottom: 30px;
  position: relative;
}
.speakerDetailsImage__content span::before {
  position: absolute;
  bottom: -23px;
  left: 0;
  height: 1px;
  width: 170px;
  border: 1px dashed #7B26BE;
  content: "";
}

.speakerDetailsImage-para {
  padding-top: 13px;
  font-size: 16px;
  line-height: 1.75rem;
  margin-bottom: 13px;
}

.speaker-details-quote {
  position: relative;
  padding: 20px 20px;
  padding-bottom: 10px;
  background: #F6F2FB;
  margin-bottom: 30px;
}
.speaker-details-quote::before {
  position: absolute;
  left: 0;
  top: 0;
  height: 100%;
  width: 6px;
  background: #7B26BE;
  content: "";
}
.speaker-details-quote::after {
  position: absolute;
  content: "";
  background-image: url(../img/speaker-details/speaker-quote.png);
  background-repeat: no-repeat;
  height: 100%;
  width: 100%;
  top: 11px;
  left: 33%;
}
.speaker-details-quote p {
  color: #14133B;
  font-size: 16px;
  line-height: 1.75rem;
  font-weight: 600;
}

.speaker-details-social {
  border-top: 1px dashed #7B26BE;
  display: inline-block;
}

.speaker-details-social {
  padding-top: 24px;
  margin-bottom: 24px;
}
.speaker-details-social ul li {
  display: inline-block;
  margin-right: 10px;
  border: 2px solid #7B26BE;
  border-radius: 50px;
  height: 25px;
  width: 25px;
  line-height: 20px;
  text-align: center;
  font-size: 14px;
  padding-bottom: 0;
  color: #7B26BE;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.speaker-details-social ul li:hover {
  background: linear-gradient(180deg, #a633fe 0%, #2300db 100%);
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
  color: #fff;
}

.website-link {
  display: flex;
}
.website-link h5 {
  text-transform: capitalize;
  margin-right: 10px;
  font-weight: 600;
  color: #1E1E1E;
}
.website-link a {
  text-transform: capitalize;
  color: #7B26BE;
  text-decoration: underline;
  font-weight: 600;
}

.skills-area {
  background: #F6F2FB;
  padding-bottom: 100px;
}

.progress-bar.progess-bg {
  background: #a633fe;
  background: linear-gradient(280deg, #a633fe 0%, #2300db 100%);
  border-radius: 50px;
}

.progress.progress-wrapper {
  border-radius: 50px;
  background: #E5E5E5;
  margin-bottom: 10px;
}

.progress-content {
  display: flex;
  justify-content: space-between;
  margin-bottom: 15px;
}
.progress-content:first-child {
  font-size: 18px;
  color: #1E1E1E;
  font-weight: 600;
}

.skills-name {
  border-bottom: 1px dashed #1578E9;
  margin-bottom: 30px;
}

.skill-title {
  font-size: 22px;
  line-height: 2.188rem;
  color: #1E1E1E;
  font-weight: 700;
  text-transform: uppercase;
  margin-bottom: 40px;
}

.degree {
  padding-left: 60px;
  position: relative;
  padding-bottom: 30px;
}
.degree::before {
  position: absolute;
  left: 0;
  top: 50%;
  width: 14px;
  height: 14px;
  background: #B8B8B8;
  content: "";
  border-radius: 50px;
  transform: translateY(-50%);
}
.degree h3 {
  font-size: 18px;
  color: #1E1E1E;
  line-height: 1.125rem;
  font-weight: 600;
}
.degree p {
  font-size: 16px;
  line-height: 1.75rem;
}

.wrapper-degree {
  padding-left: 50px;
  position: relative;
}

.degree-wrapper {
  position: relative;
}
.degree-wrapper::before {
  position: absolute;
  left: 6px;
  height: 100%;
  width: 1px;
  background: #E5E5E5;
  content: "";
  top: 0;
}

.skill-wr-two {
  position: relative;
  z-index: 9;
  margin-bottom: 46px;
}

.dgraduation-add-before {
  position: relative;
}

.iconbox {
  display: inline-block;
  background: #2A06A8;
  height: 43px;
  width: 43px;
  border-radius: 50px;
  line-height: 43px;
  text-align: center;
  margin-left: -15px;
  box-shadow: 0px 6px 15px #651AED2E;
  border-radius: 22px;
}

.wrapper-two {
  padding-left: 15px;
}

.event-card-title, .eventCard__body h3 {
  font-size: 22px;
  font-weight: 700;
  line-height: 2.188rem;
  color: #1E1E1E;
  margin-bottom: 50px;
}

.even-card-area {
  padding: 20px;
  padding-bottom: 40px;
  position: relative;
}

.eventCard {
  border: 1px solid #F2E2FF;
  box-shadow: 0px 6px 15px #7000C82E;
  cursor: pointer;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  border-radius: 8px;
  position: relative;
  margin-bottom: 30px;
}
.eventCard:hover {
  transform: translateY(-5px);
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.eventCard__header {
  border-top-left-radius: 8px;
  border-top-right-radius: 8px;
  padding: 24px;
  background: #a633fe;
  background: linear-gradient(160deg, #a633fe 0%, #2300db 100%);
}
.eventCard__header ul {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.eventCard__header ul li {
  line-height: 1.75rem;
  color: #fff;
}
.eventCard__body {
  padding: 24px;
}
.eventCard__body h3 {
  margin-bottom: 0;
}
.eventCard__footer {
  padding: 24px;
  padding-top: 10px;
}
.eventCard__footer ul li {
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0%;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  font-weight: 700;
}
.eventCard__footer ul li img {
  margin-right: 10px;
}

.event-single-1 {
  bottom: 115px;
  right: 0;
}

.sponsor-title-inner {
  color: #0D1422;
  font-size: 40px;
  line-height: 4.063rem;
  text-transform: capitalize;
  text-align: center;
  margin-bottom: 50px;
  font-weight: 700;
}

.sponsor-wrap.spnsor-design-two {
  padding: 8px;
  position: relative;
}

.sponsor-area-design-two {
  position: relative;
  overflow: visible;
}

.sponsor-area-design-two-shape-01 {
  position: absolute;
}

.sponsor-area-design-two-shape-01 {
  top: 45%;
}

.sponsor-area-design-two-shape-02 {
  right: 0;
  top: 38%;
}

.spn-wrap {
  position: relative;
}

.spn-wrap::before {
  position: absolute;
  left: 0;
  content: "";
  border-bottom: 1px dashed #ddd;
  height: 101%;
  width: 100%;
  bottom: -69px;
}

.sponsor-form-area {
  position: relative;
}

.wrap-all-button {
  display: flex;
  justify-content: flex-start;
  text-transform: capitalize;
  align-items: center;
  margin-bottom: 30px;
  flex-wrap: wrap;
}

.wrap-radio input {
  margin-right: 10px;
  width: 20px;
  height: 20px;
}

.wrap-radio {
  display: flex;
  align-items: center;
  font-size: 16px;
  line-height: 28px;
  margin-right: 30px;
  font-weight: 600;
  color: #1e1e1e;
}

.wrap-form-radio h4 {
  font-size: 16px;
  font-weight: 600;
  color: #1E1E1E;
  margin-bottom: 20px;
  font-weight: 600;
}

.conditon p span {
  color: #7B26BE;
  line-height: 28px;
  font-weight: 700;
  text-transform: uppercase;
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.form-btn {
  position: relative;
  cursor: pointer;
  display: inline-block;
}

.sponsor-form {
  background: #ECE6FB;
  padding: 40px 60px;
}

.wrap-form.wrap-w input {
  border: 2px solid #DFDFDF;
}
.wrap-form.wrap-w input:focus {
  border: 2px solid #7B26BE;
}

.sponsor-form-area {
  overflow: hidden;
}

.moreinfo {
  display: flex;
  justify-content: flex-start;
}

.moreinfo__thumb {
  background: #fff;
  height: 60px;
  width: 60px;
  box-shadow: 0px 13px 26px #3399cc33;
  border-radius: 8px;
  text-align: center;
  line-height: 60px;
  margin-right: 20px;
}
.moreinfo__thumb img {
  width: 40%;
}

.moreinfo__content h4 {
  color: #717171;
}

.wrap-increse-btn h4 {
  font-size: 16px;
  font-weight: 600;
  color: #1E1E1E;
  margin-bottom: 20px;
  text-transform: capitalize;
}

.calculationn {
  display: flex;
  justify-content: space-around;
  align-items: center;
  position: relative;
}

.wrap-checkoutt {
  margin-bottom: 30px;
}

.resultt-field {
  background: #fff;
  color: #fff;
  padding: 18px 52px;
  display: inline-block;
  border-radius: 30px;
  color: #1e1e1e;
}

span#decrementt {
  display: inline-block;
  font-size: 19px;
  height: 30px;
  width: 30px;
  background: #2A06A8;
  color: #fff;
  line-height: 30px;
  border-radius: 50px;
  position: absolute;
  left: -8px;
  text-align: center;
}

span#incrementt {
  display: inline-block;
  font-size: 19px;
  height: 30px;
  width: 30px;
  background: #2A06A8;
  color: #fff;
  line-height: 30px;
  border-radius: 50px;
  position: absolute;
  right: 2px;
  text-align: center;
}

.wrap-increse-btn {
  padding-left: 16px;
}

.text-area textarea {
  width: 100%;
  height: 225px;
  border: 1px solid #DFDFDF;
  padding: 30px;
  text-transform: capitalize;
  margin-bottom: 30px;
  border-radius: 8px;
}

.text-area h4 {
  font-size: 16px;
  font-weight: 600;
  color: #1E1E1E;
  margin-bottom: 20px;
  text-transform: capitalize;
}

.pbt {
  font-size: 16px;
  padding: 22px;
  line-height: 28px;
  padding-top: 15px;
}

/*
===========================
register area start 
===========================
*/
.register-area {
  background-image: url("../img/parallax/paralax-bg.png");
  background-repeat: no-repeat;
  background-size: cover;
  height: 100%;
  width: 100%;
  margin-top: 116px;
  position: relative;
  overflow: hidden;
  padding-bottom: 60px;
  padding-top: 105px;
}
.register-area::before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background: transparent linear-gradient(105deg, #3399CC 0%, #2A06A8 1%, #7B26BE 100%) 0% 0% no-repeat padding-box;
  opacity: 0.8;
  left: 0;
  top: 0;
}

.register-subtitle {
  margin-bottom: 10px;
}

.cmn_btn.register_btn {
  border: 1px solid #fff;
  color: #fff;
  padding: 21px 48px;
}
.cmn_btn.register_btn img {
  padding-left: 10px;
}

.register-area-two {
  background-image: url("../img/home-two/price/smoke-bg.png");
  background-repeat: no-repeat;
  background-size: cover;
  padding: 50px 0;
  border-radius: 6px;
  margin-bottom: -307px;
  position: relative;
  z-index: 9;
}

/*
===========================
Blog area start 
===========================
*/
.blog-section-wrapper {
  margin-bottom: 40px;
}

.blog {
  margin-bottom: 30px;
  margin-right: 30px;
  overflow: hidden;
}
.blog__thumb {
  position: relative;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  overflow: hidden;
}
.blog__thumb img:hover {
  transform: scale(1.3);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.blog__content-meta span {
  font-size: 14px;
  line-height: 32px;
  text-transform: capitalize;
  display: inline-block;
  padding-top: 15px;
  color: #535353;
}
.blog__content-meta span:first-child {
  margin-right: 30px;
}
.blog__content h2 {
  font-size: 20px;
  font-weight: 700;
  color: #1E1E1E;
  line-height: 32px;
}
.blog__content h2:hover {
  color: #7B26BE;
}

.category-name {
  display: inline-block;
  padding: 2px 10px;
  background-color: #7B26BE;
  text-transform: capitalize;
  color: #fff;
  line-height: 28px;
  font-size: 14px;
  border-radius: 3px;
  position: absolute;
  left: 30px;
  top: 30px;
  font-weight: 600;
}

.prev-arrow-blog, .next-arrow-blog {
  position: absolute;
  right: 97px;
  top: -103px;
  background: transparent;
  border: 2px solid #2A06A8;
  padding: 9px 16px;
  display: inline-block;
  border-radius: 6px;
  font-size: 22px;
  font-weight: 700;
  color: #2A06A8;
  z-index: 9999999;
}

.next-arrow-blog {
  right: 33px;
}

.blog-area.blog-area-two {
  margin-top: 120px;
  background-image: url("../img/home-two/blog/4882066.png"), linear-gradient(#1578E9, #1578E9);
  background-repeat: no-repeat;
  background-size: cover;
  height: 100%;
  width: 100%;
  position: relative;
  padding-bottom: 70px;
}
.blog-area.blog-area-two::before {
  position: absolute;
  content: "";
  left: 0;
  top: 0;
  height: 100%;
  width: 100%;
  background: #1578E9;
  opacity: 0.3;
}

.prev-arrow-blog-2, .next-arrow-blog-2.slick-arrow {
  position: absolute;
  right: 120px;
  top: -103px;
  background: transparent;
  border: 2px solid #fff;
  padding: 9px 16px;
  display: inline-block;
  border-radius: 6px;
  font-size: 16px;
  font-weight: 700;
  color: #fff;
  z-index: 9999999;
}

.next-arrow-blog-2.slick-arrow {
  right: 53px;
}

/*
===========================
footer area start 
===========================
*/
.footer-area {
  padding-bottom: 100px;
  background-image: url("../img/footer/footer-bg-01.png");
  background-repeat: no-repeat;
  background-size: cover;
  height: 100%;
  width: 100%;
  position: relative;
  margin-top: 120px;
  z-index: 99;
  overflow: hidden;
}
.footer-area::before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background: #2A06A8 0% 0% no-repeat padding-box;
  opacity: 0.85;
  top: 0;
  left: 0;
  z-index: -1;
}

.footer_wrapper {
  display: flex;
  justify-content: space-between;
  background: #fff;
  padding: 13px 12px;
  align-items: center;
  border-radius: 6px;
  margin-bottom: 60px;
  padding-left: 20px;
}

.subscribe-logo {
  flex: 1;
}

.subscribe-box {
  flex: 2;
}
.subscribe-box form {
  position: relative;
}
.subscribe-box form::before {
  position: absolute;
  left: -50px;
  top: 0;
  border: 1px solid #B8B8B8;
  content: "";
  height: 68px;
  opacity: 0.6;
}
.subscribe-box form input {
  border: 0;
  padding: 25px 0;
  padding-left: 25px;
  width: 60%;
}

.submit-subscribe {
  padding: 23px 28px;
  background: #2A06A8;
  color: #fff;
  font-size: 16px;
  font-weight: 600;
  text-transform: uppercase;
  position: absolute;
  right: 0;
  border: 0;
  cursor: pointer;
  border-radius: 6px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.submit-subscribe img {
  padding-left: 10px;
}
.submit-subscribe:hover {
  background-color: transparent linear-gradient(90deg, #7B26BE 0%, #846fcf 100%) 0% 0% no-repeat padding-box;
  box-shadow: rgba(17, 12, 46, 0.15) 0px 48px 100px 0px;
  transform: translateY(-2px);
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
  border-radius: 6px;
}

.wrap {
  border-bottom: 1px dashed #fff;
  padding-bottom: 30px;
  margin-bottom: 35px;
}
.wrap a {
  display: inline-block;
  border: 1px solid #fff;
  border-radius: 50%;
  height: 50px;
  width: 50px;
  line-height: 50px;
  text-align: center;
  color: #fff;
  font-size: 20px;
  margin-right: 20px;
}

.copyright-text p {
  color: #fff;
  font-size: 15px;
  font-weight: 600;
  line-height: 30px;
}

.footer-area.footer-area-two {
  margin-top: 0;
  background: #fff;
  position: relative;
  z-index: 99;
  overflow: hidden;
}
.footer-area.footer-area-two::before {
  background: #fff;
}

.submit-subscribe.submit-subscribe-btn {
  border: 0;
  background: #1578E9;
  border-radius: 6px;
}

.footer_wrapper.footer-wrapper-two {
  background: #FFFFFF 0% 0% no-repeat padding-box;
  box-shadow: 0px 15px 35px #1578E94F;
  border-radius: 6px;
}

.copyright-text.copyright-text-two p {
  color: #717171;
}

.wrap.wrap-two {
  border-bottom: 1px dashed #B8B8B8;
  padding-bottom: 30px;
  margin-bottom: 35px;
}

.wrap.wrap-two a {
  display: inline-block;
  border: 1px solid #1578E9;
  border-radius: 50%;
  height: 50px;
  width: 50px;
  line-height: 50px;
  text-align: center;
  color: #1578E9;
  font-size: 20px;
  margin-right: 20px;
}

.large-footer-shapes-01 {
  position: absolute;
  z-index: -1;
  top: 43px;
  left: -8%;
}

.large-footer-shapes-02 {
  position: absolute;
  right: -68px;
  bottom: -53px;
  width: 10%;
}

.position-absolute.footer_ractangle_08 {
  left: 378px;
  top: 7px;
  opacity: 0.3;
}

.position-absolute.footer_ractangle_07 {
  top: 247px;
  left: 400px;
  opacity: 0.2;
  z-index: -1;
}

.position-absolute.footer_ractangle_03 {
  right: 135px;
  top: 180px;
  opacity: 0.2;
}

.position-absolute.footer_ractangle_09 {
  bottom: 29px;
  right: 20px;
  opacity: 0.2;
}

.position-absolute.footer_ractangle_06 {
  top: 420px;
  left: 14px;
  opacity: 0.2;
}

.position-absolute.footer_ractangle_05 {
  bottom: 60px;
  left: 499px;
  opacity: 0.2;
}

.position-absolute.footer_ractangle_04 {
  top: 89px;
  left: 985px;
  opacity: 0.2;
  z-index: -1;
}

.position-absolute.footer_ractangle_02 {
  bottom: 144px;
  right: 504px;
  opacity: 0.2;
}

.chec {
  position: absolute;
  top: 25%;
  left: 35%;
}

.speaker {
  position: absolute;
  bottom: 9%;
  left: 21%;
}

.small-menu {
  width: 300px;
  height: 100%;
  background: #fff;
  position: fixed;
  z-index: 999999999999;
  right: 0;
}

.mean-container a.meanmenu-reveal span {
  display: block;
  background: #000;
  height: 3px;
  margin-top: 3px;
}

.small-menu {
  width: 300px;
  height: 100%;
  background: #fff;
  position: fixed;
  z-index: 99;
  right: 0;
  padding: 30px;
}

.mean-container a.meanmenu-reveal {
  width: 22px;
  height: 22px;
  padding: 13px 13px 11px 13px;
  position: absolute;
  top: 0px;
  right: 0;
  cursor: pointer;
  color: #383535;
  text-decoration: none;
  font-size: 16px;
  text-indent: -9999em;
  line-height: 22px;
  font-size: 1px;
  display: block;
  font-family: Arial, Helvetica, sans-serif;
  font-weight: 700;
}

.design-menu .mean-bar .mean-nav ul li a {
  font-size: 12px;
}

.mean-container .mean-nav ul li {
  position: relative;
  float: left;
  width: 100%;
  padding-left: 10px;
}

.design-menu .mobile-menu .mean-bar .mean-nav ul {
  display: block !important;
}

.design-menu .mean-bar .mean-nav ul li a {
  font-size: 12px;
  color: #000;
}

.mean-container .mean-nav {
  float: left;
  width: 100%;
  margin-top: 44px;
  background: transparent;
}

.mean-container .mean-nav ul li {
  position: relative;
  float: left;
  width: 100%;
  padding-left: 10px;
  border-bottom: 1px solid #ddd;
}

.small-menu {
  display: none;
}

.offcanvas-overlay {
  position: fixed;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  background: #000;
  height: 100%;
  width: 100%;
  z-index: 99999999;
  opacity: 0;
  visibility: hidden;
}

.offcanvas-overlay.overlay-open {
  opacity: 0.5;
  visibility: visible;
}

.activemobile.activemobile-two {
  background-color: #F8FBFF;
}

.open-mobile-menu.mobile-menu-two {
  color: #000;
}

.mean-container .mean-nav ul li a {
  padding: 10px 0px;
}

.mean-container .mean-nav ul li {
  padding-left: 0;
}

.mean-container .mean-nav ul li {
  padding-left: 0;
}

.mean-container .mean-nav ul li a.mean-expand:hover, .mean-container .mean-nav ul li a.mean-clicked {
  background: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  border-image: transparent linear-gradient(90deg, #7B26BE 0%, #2A06A8 100%) 0% 0% no-repeat padding-box;
  color: #fff;
}

.mean-container .mean-nav ul li a.mean-expand {
  border: 1px solid #7b26be !important;
}

/*
===========================
Blog Inner area start 
===========================
*/
.inner_header {
  position: static;
}

.breadcrumb_area {
  background-image: url("../img/blog/breadcrube.png");
  background-size: cover;
  background-position: center center;
  width: 100%;
  height: 100%;
  position: relative;
  padding: 80px 0;
  padding-bottom: 100px;
}
.breadcrumb_area::before {
  position: absolute;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  content: "";
  background: transparent linear-gradient(99deg, #A633FE 0%, #2300DB 100%) 0% 0% no-repeat padding-box;
  opacity: 0.75;
}

.br-shapes-02 {
  right: 0;
}

.br-shapes-01 {
  top: 0;
}

.triangle-01 {
  color: #fff;
  font-size: 12px;
  line-height: 21px;
  display: inline-block;
  background: #FE9933;
  padding: 8px 23px;
  text-align: center;
  padding-left: 10px;
  padding-top: 7px;
  margin-right: 10px;
  clip-path: polygon(0% 0%, 80% 0%, 100% 56%, 78% 100%, 0% 100%);
  line-height: 21px;
  font-weight: 500;
}

.triangle-02 {
  display: inline-block;
  padding: 8px 23px;
  padding-left: 0;
  padding-top: 7px;
  position: relative;
  color: #fff;
  z-index: 9;
  font-size: 12px;
  line-height: 21px;
  font-weight: 500;
}
.triangle-02 a {
  display: block;
  padding-left: 4px;
}
.triangle-02::before {
  position: absolute;
  left: -45px;
  top: 0;
  content: "";
  clip-path: polygon(36% 0%, 100% 0%, 100% 100%, 38% 100%, 68% 53%);
  background: #3399CC;
  height: 100%;
  width: 100%;
  z-index: -1;
}
.triangle-02::after {
  clip-path: polygon(0% 0%, 80% 0%, 100% 50%, 80% 100%, 0% 100%);
  background: #3399CC;
  height: 100%;
  width: 100%;
  z-index: -1;
  position: absolute;
  content: "";
  right: 0;
  top: 0;
}

.br-title {
  font-size: 65px;
  line-height: 85px;
  font-weight: 900;
  color: #fff;
}

.cmn_widget, .search_widgets {
  background: #FFFFFF 0% 0% no-repeat padding-box;
  box-shadow: 0px 6px 30px #00000012;
  border-radius: 10px;
  padding: 24px 24px;
  position: relative;
  margin-bottom: 30px;
}

.search_widgets form {
  position: relative;
}
.search_widgets form input {
  width: 100%;
  padding: 15px 20px;
  border: 1px solid #D5E0EF;
  border-radius: 6px;
  padding-right: 50px;
}
.search_widgets form button {
  position: absolute;
  right: 0;
  font-size: 23px;
  top: 50%;
  left: auto;
  transform: translate(-50%, -50%);
  color: #7B26BE;
  border: 0;
  background: transparent;
  cursor: pointer;
}

.widget-title {
  font-size: 20px;
  line-height: 32px;
  color: #030519;
  font-weight: 700;
}

.recent {
  align-items: center;
  border-bottom: 1px dashed #D5E0EF;
  margin-bottom: 25px;
  padding-top: 10px;
}
.recent__thumb {
  margin-right: 10px;
  overflow: hidden;
  float: left;
  clear: left;
}
.recent__thumb img {
  width: 100%;
}
.recent__content span {
  font-size: 14px;
  line-height: 28px;
  color: #858585;
}
.recent__content a p {
  font-size: 16px;
  color: #030519;
  line-height: 28px;
  font-weight: 600;
}
.recent__content a p:hover {
  color: #7B26BE;
}

.category ul li {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding-bottom: 15px;
  padding-top: 15px;
  font-size: 15px;
  line-height: 23px;
  border-bottom: 1px dashed #D5E0EF;
  color: #7A7A7A;
}
.category ul li a i {
  display: inline-block;
  padding-right: 14px;
  color: #7B26BE;
}
.category ul li span {
  color: #7A7A7A;
}
.category ul li:hover {
  color: #7B26BE;
}

.tags ul li {
  list-style: none;
  display: inline-block;
  padding: 9px 12px;
  border: 1px solid #D5E0EF;
  margin-bottom: 10px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.tags ul li:hover {
  background: #7B26BE;
  color: #fff;
}

.custom_pagination ul li {
  display: inline-block;
  text-transform: capitalize;
  margin-right: 14px;
  border: 1px solid #DDDDDD;
  font-size: 16px;
  line-height: 30px;
  text-align: center;
  padding: 3px 11px;
  color: #555555;
  font-weight: 600;
  text-transform: uppercase;
  margin-bottom: 30px;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}
.custom_pagination ul li:first-child {
  border: 0;
}
.custom_pagination ul li:last-child {
  border: 0;
}
.custom_pagination ul li:hover {
  background-color: #7B26BE;
  color: #fff;
  -webkit-transition: all 0.2s ease-out 0s;
  -moz-transition: all 0.2s ease-out 0s;
  -ms-transition: all 0.2s ease-out 0s;
  -o-transition: all 0.2s ease-out 0s;
  transition: all 0.2s ease-out 0s;
}

.innerFooter {
  margin-top: 20px;
}

.classic {
  padding-bottom: 30px;
  border-bottom: 1px dashed #CBCBCB;
  margin-bottom: 30px;
}
.classic__thumb {
  position: relative;
  overflow: hidden;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.classic__thumb img {
  width: 100%;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.classic__thumb img:hover {
  transform: scale(1.1);
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.classic__thumb::before {
  position: absolute;
  top: 0;
  left: -75%;
  z-index: 2;
  display: block;
  content: "";
  width: 50%;
  height: 100%;
  background: -webkit-linear-gradient(left, rgba(219, 218, 218, 0) 0%, rgba(255, 255, 255, 0.2) 100%);
  background: linear-gradient(to right, rgba(218, 216, 216, 0) 0%, rgba(255, 255, 255, 0.2) 100%);
  -webkit-transform: skewX(-25deg);
  transform: skewX(-25deg);
}
.classic__thumb:hover::before {
  -webkit-animation: shine 0.75s;
  animation: shine 0.75s;
}
.classic__content p {
  font-size: 16px;
  line-height: 30px;
  color: #484848;
}

@-webkit-keyframes shine {
  100% {
    left: 125%;
  }
}
@keyframes shine {
  100% {
    left: 125%;
  }
}
.category-name-two {
  position: absolute;
  bottom: 20px;
  left: 20px;
  display: inline-block;
  padding: 2px 10px;
  background-color: #7B26BE;
  text-transform: capitalize;
  color: #fff;
  line-height: 28px;
  font-size: 14px;
  border-radius: 3px;
  font-weight: 600;
}

.classic_title {
  font-size: 20px;
  line-height: 32px;
  color: #030519;
  font-weight: 700;
}

.classic_btn {
  color: #7B26BE;
  font-size: 16px;
  font-weight: 600;
  line-height: 28px;
  text-transform: capitalize;
  padding-top: 5px;
}
.classic_btn i {
  display: inline-block;
  padding-left: 10px;
  font-weight: 600;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}
.classic_btn:hover i {
  padding-left: 20px;
  -webkit-transition: all 0.3s ease-out 0s;
  -moz-transition: all 0.3s ease-out 0s;
  -ms-transition: all 0.3s ease-out 0s;
  -o-transition: all 0.3s ease-out 0s;
  transition: all 0.3s ease-out 0s;
}

.details_listing {
  padding: 10px 0;
}
.details_listing li {
  position: relative;
  padding-left: 45px;
  line-height: 30px;
  font-size: 16px;
  z-index: 9;
  font-size: 16px;
  display: block;
  margin-bottom: 8px;
}
.details_listing li::before {
  position: absolute;
  left: 0;
  height: 26px;
  width: 26px;
  content: "\f00c";
  top: 0;
  color: #7B26BE;
  font-family: "Font Awesome 5 Pro";
  font-weight: 700;
  background: rgba(123, 38, 190, 0.1);
  border-radius: 50px;
  z-index: -1;
  text-align: center;
  line-height: 30px;
  font-size: 14px;
}

.details_image {
  display: flex;
  justify-content: space-between;
  padding: 5px 0;
  padding-bottom: 30px;
}

.detailsImage_two {
  position: relative;
}

.play-video-blog {
  position: absolute;
  left: 50%;
  top: 50%;
}

.video-play-button.play-video-blog:after {
  border: 3px solid #fff;
  background: rgba(123, 38, 190, 0.3);
}

.post_tags {
  padding-top: 20px;
  border-top: 1px dashed #CECECE;
}
.post_tags ul li {
  display: inline-block;
  padding: 3px 24px;
  background: #F3F3F3;
  font-size: 14px;
  line-height: 30px;
  font-weight: 500;
  margin-right: 10px;
}
.post_tags ul li:first-child {
  padding: 0;
  background: transparent;
}

.single_pagination ul {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.bg-icon {
  display: inline-block;
  background: #7B26BE;
  padding: 12px 20px;
  border-radius: 6px;
  color: #fff;
  font-size: 19px;
  font-weight: 700;
  cursor: pointer;
}

.sugesst_title, .title_comments {
  font-size: 24px;
  line-height: 44px;
  color: #0D1422;
  font-weight: 600;
  text-transform: capitalize;
}

.details {
  border: 0;
  color: #7B26BE;
}

.blog-quote {
  background: #F2E2FF;
  padding: 30px 104px;
  position: relative;
}

.blog-quote-sign {
  position: absolute;
  top: 25px;
  left: 40px;
}

.quote-title {
  font-size: 18px;
  line-height: 30px;
  font-weight: 600;
  color: #000;
}

.quote-name {
  font-size: 16px;
  line-height: 30px;
  color: #484848;
  position: relative;
  padding-left: 100px;
}
.quote-name::before {
  position: absolute;
  left: 0px;
  top: 50%;
  background: #707070;
  width: 70px;
  height: 1px;
  content: "";
  transform: translateY(-50%);
}

.detail-two {
  padding-top: 30px;
}

.form-title {
  font-size: 16px;
  line-height: 30px;
  color: #484848;
}

.wrap-form input {
  width: 100%;
  border: 2px solid #7B26BE;
  padding: 12px 24px;
  border-radius: 6px;
  text-transform: capitalize;
  margin-bottom: 30px;
}
.wrap-form textarea {
  width: 100%;
  height: 180px;
  border: 1px solid #DFDFDF;
  padding: 17px 24px;
  margin-bottom: 50px;
}

/*
===========================
benefit area start 
===========================
*/
.benifit-area {
  background-image: url("../img/about-inner/bg-benifit.png");
  background-size: cover;
  background-position: center;
  width: 100%;
  height: 100%;
  position: relative;
  padding-bottom: 30px;
}
.benifit-area::before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  top: 0;
  mix-blend-mode: screen;
  opacity: 1;
  left: 0;
  background: #7000c8;
  background: linear-gradient(90deg, #7000c8 0%, #7000c8 35%);
}
.benifit-area::after {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  top: 0;
  left: 0;
  background: #a633fe;
  background: linear-gradient(180deg, rgba(166, 51, 254, 0.75) 0%, rgba(35, 0, 219, 0.75) 100%);
}

.section-para {
  color: #fff;
  font-size: 16px;
  line-height: 28px;
}

.benefit {
  margin-bottom: 50px;
  text-align: left;
  cursor: pointer;
}
.benefit__thumb img {
  margin-bottom: 25px;
}
.benefit__content {
  color: #fff;
}
.benefit__content h3 {
  line-height: 35px;
  font-size: 22px;
  font-weight: 700;
  text-transform: uppercase;
  padding-bottom: 20px;
}
.benefit__content p {
  color: #fff;
  font-size: 16px;
  line-height: 28px;
}

.benefit-shape-01 {
  top: 0;
}

/*
===========================
contact area start 
===========================
*/
.counterWrapper-two {
  position: relative;
  padding: 30px;
  border: 2px solid #F6F2FB;
  padding-bottom: 0;
}
.counterWrapper-two::before {
  left: 52%;
}

.contact-title-1 {
  color: #7B26BE;
  font-size: 16px;
  line-height: 1.75rem;
  margin-bottom: 0;
}

p.contact-sub-title {
  font-size: 18px;
  line-height: 2.188rem;
  font-weight: 600;
}

.contact-card {
  position: relative;
  overflow: hidden;
}

.speaker-single-f {
  right: 50px;
}

.contact-para {
  font-size: 16px;
  line-height: 1.75rem;
}

.wrap-input input {
  width: 100%;
  padding: 13px;
  margin-bottom: 30px;
  background: #fff;
}

.border-gradient {
  border: 5px solid;
  border-image-slice: 1;
  border-width: 2px;
  border-radius: 5px;
}

.border-gradient-purple {
  border-image-source: linear-gradient(280deg, #a633fe 0%, #2300db 100%);
  border-radius: 5px;
}

.wrap-input textarea {
  width: 100%;
  height: 225px;
  padding: 15px;
  text-transform: capitalize;
  border: 0;
  margin-bottom: 30px;
  border-radius: 8px;
}
.wrap-input a {
  display: inline-block;
  text-transform: capitalize;
}

.form-wrapper {
  background-image: url("../img/contact/back-contact.png");
  background-size: cover;
  background-repeat: no-repeat;
  position: relative;
  z-index: 9;
  padding: 60px;
}

.form-section {
  margin-bottom: 90px;
}

.form-main-wrapper {
  background: #F1E7FC;
}

.contact-map {
  filter: grayscale(1);
}

.removemt {
  margin-top: -10px;
}

.contact-map {
  position: relative;
}
.contact-map::before {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  background: #fff;
  background-image: url("../img/contact/contactmap.png");
  height: 100px;
  width: 100px;
  border-radius: 50px;
  z-index: 99999999999;
  content: "";
  background-repeat: no-repeat;
  filter: grayscale(0) !important;
  line-height: 100px;
  text-align: center;
  background-position: center;
}

.venue_inner {
  width: 100%;
  border: 0;
  position: relative;
}

iframe {
  border: 0;
}

.gmnoprint {
  display: none !important;
}

.gmnoprint.gm-bundled-control.gm-bundled-control-on-bottom {
  display: none !important;
}

.map {
  position: absolute;
  top: 80px;
  right: 170px;
  background: #fff;
  box-shadow: 0px 10px 30px #00000029;
  border-radius: 10px;
}

.map__header {
  display: flex;
  align-items: center;
  background: #a633fe;
  background: linear-gradient(-260deg, #a633fe 0%, #2300db 100%);
  padding: 17px 35px;
  border-radius: 10px;
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}
.map__header img {
  margin-right: 30px;
}
.map__header h2 {
  font-size: 22px;
  line-height: 35px;
  color: #fff;
  font-weight: 700;
}

.map__body {
  padding: 10px 30px;
  padding-bottom: 30px;
}
.map__body h4 {
  font-size: 16px;
  line-height: 28px;
  text-align: center;
  padding: 10px 0;
  text-transform: capitalize;
  font-weight: 600;
  color: #8B8B8B;
}

button.accordion-button.custom-button {
  font-size: 20px;
  line-height: 28px;
  border: 0;
  background: transparent;
  font-weight: 600;
  margin-bottom: 20px;
}

h4.border-up {
  border-bottom: 1px dashed #DBDBDB;
}

.add-before-image {
  position: relative;
  margin-bottom: 20px;
  z-index: 2;
  padding-left: 46px;
  line-height: 30px;
}
.add-before-image::after {
  position: absolute;
  left: 0;
  top: 0;
  content: "";
  height: 34px;
  width: 34px;
  background: #F2E2FF;
  border-radius: 50px;
}

.map_accordion ul li img {
  width: 13px;
  position: relative;
  z-index: 99;
  margin-left: 11px;
  display: inline-flex;
  margin-top: 7px;
  position: absolute;
  left: 0;
}

.get-location h4 {
  font-size: 16px;
  font-weight: 600;
  color: #A131FC;
  text-transform: uppercase;
  line-height: 28px;
}
.get-location h2 {
  text-transform: capitalize;
  color: #1e1e1e;
  font-weight: 600;
  font-size: 22px;
  line-height: 35px;
}

/*
===========================
contact area start 
===========================
*/
/*-----------------------------
    Accordion Item
-----------------------------*/
.accordion-wrapper .card {
  border: none;
  background-color: transparent;
}
.accordion-wrapper .card + .card {
  margin-top: 20px;
}
.accordion-wrapper .card .card-header {
  background-color: transparent;
  padding: 0;
  border: none;
}
.accordion-wrapper .card .card-header a {
  display: block;
  font-size: 18px;
  line-height: 28px;
  font-weight: 600;
  font-family: var(--body-font);
  background-color: transparent;
  color: var(--heading-color);
  border: 1px solid var(--main-color-one);
  border-radius: 5px;
  padding: 15px 30px;
  cursor: pointer;
  position: relative;
  transition: 0.7s all ease;
  border: 1px solid #E5E5E5;
}
.accordion-wrapper .card .card-header a:after {
  position: absolute;
  right: 30px;
  top: 7px;
  content: "\f107";
  font-family: "Font Awesome 5 Pro";
  height: 40px;
  width: 40px;
  line-height: 40px;
  text-align: center;
  background: #F2E2FF;
  color: #7B26BE;
  border-radius: 50px;
}
.accordion-wrapper .card .card-header a[aria-expanded=true] {
  background: var(--main-color-one);
  border-radius: 5px 5px 0px 0px;
  color: #1e1e1e;
  background: #fff;
}
.accordion-wrapper .card .card-header a[aria-expanded=true]:after {
  content: "\f00d";
}
.accordion-wrapper .card .card-body {
  background-color: #fff;
  padding: 20px 30px;
  border: 1px solid #E5E5E5;
  border-radius: 0px 0px 5px 5px;
  font-size: 16px;
  line-height: 28px;
  font-family: var(--body-font);
  font-weight: 400;
  color: var(--heading-color);
  transition: 0.7s alternate;
}

.accoridion-section {
  background: #F7F4FC;
  padding: 116px 0px 128px 0px;
  position: relative;
  overflow: hidden;
}
.accoridion-section.style-01 {
  margin-top: 120px;
}
.accoridion-section .section-title .title {
  font-size: 40px;
  font-weight: 700;
  color: #000629;
  line-height: 55px;
}
.accoridion-section .shape {
  position: absolute;
  right: 14%;
  top: 32%;
}
.accoridion-section .shape-01 {
  position: absolute;
  top: 65%;
  left: 10%;
}
.accoridion-section .shape-02 {
  position: absolute;
  top: 15%;
  left: 20%;
}

.description {
  text-align: center;
  margin-bottom: 50px;
}

.accordion-wrapper .card .card-header a::first-letter {
  color: #7B26BE;
}

/*# sourceMappingURL=style.cs.map */
