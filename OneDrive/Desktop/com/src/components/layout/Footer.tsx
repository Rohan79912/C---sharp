import React from "react";
import Link from "next/link";
import { Camera, Mail, Globe } from "lucide-react";

const Footer = () => {
  const currentYear = new Date().getFullYear();

  return (
    <footer className="bg-black border-t border-zinc-800 pt-20 pb-10">
      <div className="max-w-7xl mx-auto px-6 grid grid-cols-1 md:grid-cols-4 gap-12">
        <div className="col-span-1 md:col-span-1">
          <Link href="/" className="flex items-center gap-2 mb-6">
            <Camera className="w-8 h-8 text-white" />
            <span className="text-2xl font-bold tracking-tighter text-white">LensAI</span>
          </Link>
          <p className="text-zinc-500 text-sm leading-relaxed mb-6">
            India's premier AI-powered marketplace for event media services. Connecting creators with moments that matter.
          </p>
          <div className="flex gap-4">
            <Mail className="w-5 h-5 text-zinc-400 hover:text-white cursor-pointer transition-colors" />
            <Globe className="w-5 h-5 text-zinc-400 hover:text-white cursor-pointer transition-colors" />
            <Camera className="w-5 h-5 text-zinc-400 hover:text-white cursor-pointer transition-colors" />
          </div>
        </div>

        <div>
          <h4 className="text-white font-semibold mb-6">Platform</h4>
          <ul className="space-y-4 text-sm text-zinc-500">
            <li><Link href="#" className="hover:text-white transition-colors">Find Photographers</Link></li>
            <li><Link href="#" className="hover:text-white transition-colors">AI Editing Tools</Link></li>
            <li><Link href="#" className="hover:text-white transition-colors">Pricing Plans</Link></li>
            <li><Link href="#" className="hover:text-white transition-colors">Case Studies</Link></li>
          </ul>
        </div>

        <div>
          <h4 className="text-white font-semibold mb-6">Company</h4>
          <ul className="space-y-4 text-sm text-zinc-500">
            <li><Link href="#" className="hover:text-white transition-colors">About Us</Link></li>
            <li><Link href="#" className="hover:text-white transition-colors">Careers</Link></li>
            <li><Link href="#" className="hover:text-white transition-colors">Privacy Policy</Link></li>
            <li><Link href="#" className="hover:text-white transition-colors">Terms of Service</Link></li>
          </ul>
        </div>

        <div>
          <h4 className="text-white font-semibold mb-6">Contact</h4>
          <ul className="space-y-4 text-sm text-zinc-500">
            <li>support@lensai.com</li>
            <li>+91 98765 43210</li>
            <li>Prayagraj, Uttar Pradesh, India</li>
          </ul>
        </div>
      </div>

      <div className="max-w-7xl mx-auto px-6 mt-20 pt-8 border-t border-zinc-900 flex flex-col md:flex-row justify-between items-center gap-4 text-xs text-zinc-600">
        <p>© {currentYear} LensAI. All rights reserved.</p>
        <p className="flex items-center gap-1">
          Developed with ♥ by <span className="text-zinc-400 font-medium">Rohan Kushwaha</span> (CEO)
        </p>
      </div>
    </footer>
  );
};

export default Footer;
