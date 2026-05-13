import React from "react";
import { Zap, ShieldCheck, Cpu, Globe } from "lucide-react";

const features = [
  {
    title: "AI Smart Matching",
    description: "Our algorithm matches you with the perfect photographer based on style, equipment, and location.",
    icon: <Cpu className="w-6 h-6" />,
  },
  {
    title: "Standardized Quality",
    description: "Every creator goes through a rigorous verification process to ensure premium delivery every time.",
    icon: <ShieldCheck className="w-6 h-6" />,
  },
  {
    title: "Same-Day Delivery",
    description: "Proprietary AI editing pipeline allows us to deliver highlight reels within 24 hours of the event.",
    icon: <Zap className="w-6 h-6" />,
  },
  {
    title: "Nationwide Network",
    description: "Available in all major cities including Prayagraj, Lucknow, Varanasi, and beyond.",
    icon: <Globe className="w-6 h-6" />,
  },
];

const Features = () => {
  return (
    <section id="services" className="py-24 bg-zinc-950">
      <div className="max-w-7xl mx-auto px-6">
        <div className="text-center mb-16">
          <h2 className="text-3xl md:text-5xl font-bold text-white mb-4">Why Choose LensAI?</h2>
          <p className="text-zinc-500 max-w-xl mx-auto">
            We are redefining event media by combining human creativity with AI-powered efficiency.
          </p>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
          {features.map((feature, index) => (
            <div 
              key={index} 
              className="p-8 rounded-2xl bg-zinc-900/50 border border-zinc-800 hover:border-white/20 transition-all duration-300 group"
            >
              <div className="w-12 h-12 rounded-lg bg-zinc-800 flex items-center justify-center text-white mb-6 group-hover:scale-110 transition-transform duration-300">
                {feature.icon}
              </div>
              <h3 className="text-xl font-semibold text-white mb-3">{feature.title}</h3>
              <p className="text-zinc-500 text-sm leading-relaxed">{feature.description}</p>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
};

export default Features;
