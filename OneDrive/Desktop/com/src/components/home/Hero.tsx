import React from "react";
import { ArrowRight, Play, Camera, Sparkles, Zap, ShieldCheck } from "lucide-react";

const Hero = () => {
  return (
    <section className="relative min-h-screen flex items-center justify-center pt-20 overflow-hidden">
      {/* Background Glow */}
      <div className="absolute top-1/4 left-1/2 -translate-x-1/2 w-[800px] h-[400px] bg-zinc-900/50 blur-[120px] rounded-full -z-10" />
      
      <div className="max-w-7xl mx-auto px-6 text-center">
        <div className="inline-flex items-center gap-2 px-3 py-1 rounded-full border border-zinc-800 bg-zinc-900/50 text-zinc-400 text-xs font-medium mb-8 animate-in fade-in slide-in-from-bottom-4 duration-1000">
          <Sparkles className="w-3 h-3 text-white" />
          <span>India's First AI-Powered Media Marketplace</span>
        </div>
        
        <h1 className="text-5xl md:text-8xl font-bold tracking-tight text-white mb-8 animate-in fade-in slide-in-from-bottom-6 duration-1000 delay-200">
          Capture Every <span className="text-gradient">Moment</span> <br /> 
          with AI Intelligence.
        </h1>
        
        <p className="max-w-2xl mx-auto text-zinc-400 text-lg md:text-xl mb-12 animate-in fade-in slide-in-from-bottom-8 duration-1000 delay-300">
          Book professional photographers, videographers, and editors nationwide. 
          Standardized quality, same-day delivery, and AI-powered editing at your fingertips.
        </p>
        
        <div className="flex flex-col md:flex-row items-center justify-center gap-4 animate-in fade-in slide-in-from-bottom-10 duration-1000 delay-500">
          <button className="premium-button flex items-center gap-2 text-lg">
            Book a Shoot <ArrowRight className="w-5 h-5" />
          </button>
          <button className="secondary-button flex items-center gap-2 text-lg">
            <Play className="w-4 h-4 fill-current" /> Watch Showreel
          </button>
        </div>

        <div className="mt-20 grid grid-cols-2 md:grid-cols-4 gap-8 opacity-40 grayscale hover:grayscale-0 transition-all duration-700">
          <div className="flex items-center justify-center gap-2 text-white font-semibold">WEDDINGS</div>
          <div className="flex items-center justify-center gap-2 text-white font-semibold">CORPORATE</div>
          <div className="flex items-center justify-center gap-2 text-white font-semibold">CONCERTS</div>
          <div className="flex items-center justify-center gap-2 text-white font-semibold">CREATORS</div>
        </div>
      </div>
    </section>
  );
};

export default Hero;
